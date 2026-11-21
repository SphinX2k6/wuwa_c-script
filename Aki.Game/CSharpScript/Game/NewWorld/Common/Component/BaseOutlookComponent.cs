using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Common.Component
{
	// Token: 0x020061FC RID: 25084
	[NullableContext(1)]
	[Nullable(0)]
	public class BaseOutlookComponent : EntityComponent
	{
		// Token: 0x0603C3FE RID: 246782 RVA: 0x0112A8EC File Offset: 0x01128AEC
		protected override bool OnClear()
		{
			foreach (KeyValuePair<int, DecorationItem> keyValuePair in this.AllDecoration)
			{
				DecorationItem value = keyValuePair.Value;
				if (value != null)
				{
					value.Clear();
				}
			}
			this.AllDecoration.Clear();
			this.CurrentDecoration.Clear();
			this.SpecialDecoration = null;
			return true;
		}

		// Token: 0x0603C3FF RID: 246783 RVA: 0x0112A968 File Offset: 0x01128B68
		protected override void OnEnable()
		{
			this.RefreshDecorationVisibility("BaseOutlookComponent.OnEnable");
		}

		// Token: 0x0603C400 RID: 246784 RVA: 0x0112A975 File Offset: 0x01128B75
		protected override void OnDisable(string reason)
		{
			this.RefreshDecorationVisibility("BaseOutlookComponent.OnDisable");
		}

		// Token: 0x0603C401 RID: 246785 RVA: 0x0112A984 File Offset: 0x01128B84
		public void RefreshDecorationVisibility(string reason)
		{
			foreach (DecorationItem decorationItem in this.AllDecoration.Values)
			{
				if (decorationItem != null)
				{
					decorationItem.RefreshVisibility(reason, true);
				}
			}
		}

		// Token: 0x0603C402 RID: 246786 RVA: 0x0112A9E4 File Offset: 0x01128BE4
		protected DecorationItem CreateDecorationItem(USkeletalMeshComponent parentMesh, int index, bool alwaysUpdate = false, bool needDelayShow = false)
		{
			return this.CreateDecorationPair(parentMesh, index, alwaysUpdate, needDelayShow).Item2;
		}

		// Token: 0x0603C403 RID: 246787 RVA: 0x0112A9F8 File Offset: 0x01128BF8
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		protected ValueTuple<int, DecorationItem> CreateDecorationPair(USkeletalMeshComponent parentMesh, int index, bool alwaysUpdate = false, bool needDelayShow = false)
		{
			DecorationItem decorationItem = new DecorationItem(this, parentMesh, index, alwaysUpdate, needDelayShow);
			this.AddRenderMesh(decorationItem);
			int num = this.DecorationUid + 1;
			this.DecorationUid = num;
			int num2 = num;
			this.AllDecoration[num2] = decorationItem;
			return new ValueTuple<int, DecorationItem>(num2, decorationItem);
		}

		// Token: 0x0603C404 RID: 246788 RVA: 0x0112AA3E File Offset: 0x01128C3E
		protected virtual void AddRenderMesh(DecorationItem item)
		{
		}

		// Token: 0x0603C405 RID: 246789 RVA: 0x0112AA40 File Offset: 0x01128C40
		protected virtual int? GetDecorationModelId(int decorationId)
		{
			return null;
		}

		// Token: 0x0603C406 RID: 246790 RVA: 0x0112AA56 File Offset: 0x01128C56
		public virtual int GetSkinId()
		{
			return 0;
		}

		// Token: 0x0603C407 RID: 246791 RVA: 0x0112AA5C File Offset: 0x01128C5C
		public bool SetSpecialDecoration(int decorationConfigId)
		{
			if (this.SkelMeshComp == null)
			{
				Log.Instance.Error(ELogModule.Decoration, ELogAuthor.LCZ, "[Decoration] No Mesh to Equip SpecialDecoration.", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			if (this.SpecialDecoration == null)
			{
				this.SpecialDecoration = this.CreateDecorationItem(this.SkelMeshComp, 1000, false, false);
			}
			return this.SpecialDecoration.SetDecorationId(decorationConfigId);
		}

		// Token: 0x0603C408 RID: 246792 RVA: 0x0112AABE File Offset: 0x01128CBE
		public int GetSpecialDecorationConfigId()
		{
			DecorationItem specialDecoration = this.SpecialDecoration;
			if (specialDecoration == null)
			{
				return 0;
			}
			return specialDecoration.GetDecorationConfigId();
		}

		// Token: 0x0603C409 RID: 246793 RVA: 0x0112AAD4 File Offset: 0x01128CD4
		[NullableContext(2)]
		public unsafe void EquipDecoration(List<int> decorationIds)
		{
			List<int> list = decorationIds ?? new List<int>();
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Decoration;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "[Decoration] Equip Decorations";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", base.Entity.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("length", list.Count);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			if (this.SkelMeshComp == null)
			{
				Log.Instance.Error(ELogModule.Decoration, ELogAuthor.LCZ, "[Decoration] No Mesh to Equip.", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			for (int i = 0; i < list.Count; i++)
			{
				DecorationItem decorationItem = null;
				if (!this.CurrentDecoration.ContainsKey(i))
				{
					ValueTuple<int, DecorationItem> valueTuple = this.CreateDecorationPair(this.SkelMeshComp, i, false, false);
					this.CurrentDecoration[i] = valueTuple.Item1;
					decorationItem = valueTuple.Item2;
				}
				else
				{
					int key = this.CurrentDecoration[i];
					this.AllDecoration.TryGetValue(key, out decorationItem);
				}
				if (decorationItem != null)
				{
					int num = list[i];
					if (num == 0)
					{
						decorationItem.SetDecorationId(0);
					}
					else
					{
						int? decorationModelId = this.GetDecorationModelId(num);
						if (decorationModelId == null)
						{
							Log instance2 = Log.Instance;
							ELogModule module2 = ELogModule.Decoration;
							ELogAuthor author2 = ELogAuthor.LCZ;
							string message2 = "[Decoration] Equip Decoration Error. 缺失Excel配置";
							<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("EntityId", base.Entity.Id);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("Id", num);
							instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
							decorationItem.SetDecorationId(0);
						}
						else
						{
							decorationItem.SetDecorationId(decorationModelId.Value);
						}
					}
				}
			}
			int count = this.CurrentDecoration.Count;
			for (int j = list.Count; j < count; j++)
			{
				int key2;
				if (this.CurrentDecoration.TryGetValue(j, out key2))
				{
					DecorationItem decorationItem2;
					if (this.AllDecoration.TryGetValue(key2, out decorationItem2) && decorationItem2 != null)
					{
						decorationItem2.Clear();
					}
					this.AllDecoration.Remove(key2);
				}
				this.CurrentDecoration.Remove(j);
			}
		}

		// Token: 0x0603C40A RID: 246794 RVA: 0x0112AD24 File Offset: 0x01128F24
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			BaseOutlookComponent baseOutlookComponent = (BaseOutlookComponent)componentTemplate;
			this.DecorationUid = baseOutlookComponent.DecorationUid;
			if (baseOutlookComponent.SkelMeshComp == null)
			{
				this.SkelMeshComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SkelMeshComp), "SkelMeshComp"))
			{
				return false;
			}
			if (baseOutlookComponent.AllDecoration == null)
			{
				this.AllDecoration = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.AllDecoration), "AllDecoration"))
			{
				return false;
			}
			if (baseOutlookComponent.CurrentDecoration == null)
			{
				this.CurrentDecoration = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CurrentDecoration), "CurrentDecoration"))
			{
				return false;
			}
			if (baseOutlookComponent.SpecialDecoration == null)
			{
				this.SpecialDecoration = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SpecialDecoration), "SpecialDecoration"))
			{
				return false;
			}
			return true;
		}

		// Token: 0x170071B3 RID: 29107
		// (get) Token: 0x0603C40B RID: 246795 RVA: 0x0112ADFC File Offset: 0x01128FFC
		public override bool NeedClearInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170071B4 RID: 29108
		// (get) Token: 0x0603C40C RID: 246796 RVA: 0x0112ADFF File Offset: 0x01128FFF
		public override bool NeedEnableInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170071B5 RID: 29109
		// (get) Token: 0x0603C40D RID: 246797 RVA: 0x0112AE02 File Offset: 0x01129002
		public override bool NeedDisableInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0401FE79 RID: 130681
		private const int SPECIAL_DECORATION_INDEX = 1000;

		// Token: 0x0401FE7A RID: 130682
		private int DecorationUid;

		// Token: 0x0401FE7B RID: 130683
		[Nullable(2)]
		protected USkeletalMeshComponent SkelMeshComp;

		// Token: 0x0401FE7C RID: 130684
		protected Dictionary<int, DecorationItem> AllDecoration = new Dictionary<int, DecorationItem>();

		// Token: 0x0401FE7D RID: 130685
		protected Dictionary<int, int> CurrentDecoration = new Dictionary<int, int>();

		// Token: 0x0401FE7E RID: 130686
		[Nullable(2)]
		private DecorationItem SpecialDecoration;
	}
}
