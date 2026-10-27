using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Common.Component
{
	// Token: 0x0200707B RID: 28795
	[NullableContext(1)]
	[Nullable(0)]
	public class BaseOutlookComponent : EntityComponent
	{
		// Token: 0x060461F4 RID: 287220 RVA: 0x011810D0 File Offset: 0x0117F2D0
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

		// Token: 0x060461F5 RID: 287221 RVA: 0x0118114C File Offset: 0x0117F34C
		protected override void OnEnable()
		{
			this.RefreshDecorationVisibility("BaseOutlookComponent.OnEnable");
		}

		// Token: 0x060461F6 RID: 287222 RVA: 0x01181159 File Offset: 0x0117F359
		protected override void OnDisable(string reason)
		{
			this.RefreshDecorationVisibility("BaseOutlookComponent.OnDisable");
		}

		// Token: 0x060461F7 RID: 287223 RVA: 0x01181168 File Offset: 0x0117F368
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

		// Token: 0x060461F8 RID: 287224 RVA: 0x011811C8 File Offset: 0x0117F3C8
		protected DecorationItem CreateDecorationItem(USkeletalMeshComponent parentMesh, int index, bool alwaysUpdate = false, bool needDelayShow = false)
		{
			return this.CreateDecorationPair(parentMesh, index, alwaysUpdate, needDelayShow).Item2;
		}

		// Token: 0x060461F9 RID: 287225 RVA: 0x011811DC File Offset: 0x0117F3DC
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

		// Token: 0x060461FA RID: 287226 RVA: 0x01181222 File Offset: 0x0117F422
		protected virtual void AddRenderMesh(DecorationItem item)
		{
		}

		// Token: 0x060461FB RID: 287227 RVA: 0x01181224 File Offset: 0x0117F424
		protected virtual int? GetDecorationModelId(int decorationId)
		{
			return null;
		}

		// Token: 0x060461FC RID: 287228 RVA: 0x0118123A File Offset: 0x0117F43A
		public virtual int GetSkinId()
		{
			return 0;
		}

		// Token: 0x060461FD RID: 287229 RVA: 0x01181240 File Offset: 0x0117F440
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

		// Token: 0x060461FE RID: 287230 RVA: 0x011812A2 File Offset: 0x0117F4A2
		public int GetSpecialDecorationConfigId()
		{
			DecorationItem specialDecoration = this.SpecialDecoration;
			if (specialDecoration == null)
			{
				return 0;
			}
			return specialDecoration.GetDecorationConfigId();
		}

		// Token: 0x060461FF RID: 287231 RVA: 0x011812B8 File Offset: 0x0117F4B8
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

		// Token: 0x06046200 RID: 287232 RVA: 0x01181508 File Offset: 0x0117F708
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			BaseOutlookComponent baseOutlookComponent = (BaseOutlookComponent)componentTemplate;
			if (base.CanResetComponentProperty("DecorationUid"))
			{
				this.DecorationUid = baseOutlookComponent.DecorationUid;
			}
			if (base.CanResetComponentProperty("SkelMeshComp"))
			{
				if (baseOutlookComponent.SkelMeshComp == null)
				{
					this.SkelMeshComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<USkeletalMeshComponent>(this.SkelMeshComp), "SkelMeshComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("AllDecoration"))
			{
				if (baseOutlookComponent.AllDecoration == null)
				{
					this.AllDecoration = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<int, DecorationItem>>(this.AllDecoration), "AllDecoration"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("CurrentDecoration"))
			{
				if (baseOutlookComponent.CurrentDecoration == null)
				{
					this.CurrentDecoration = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<int, int>>(this.CurrentDecoration), "CurrentDecoration"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("SpecialDecoration"))
			{
				if (baseOutlookComponent.SpecialDecoration == null)
				{
					this.SpecialDecoration = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<DecorationItem>(this.SpecialDecoration), "SpecialDecoration"))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x04024BBE RID: 150462
		private const int SPECIAL_DECORATION_INDEX = 1000;

		// Token: 0x04024BBF RID: 150463
		private int DecorationUid;

		// Token: 0x04024BC0 RID: 150464
		[Nullable(2)]
		protected USkeletalMeshComponent SkelMeshComp;

		// Token: 0x04024BC1 RID: 150465
		protected Dictionary<int, DecorationItem> AllDecoration = new Dictionary<int, DecorationItem>();

		// Token: 0x04024BC2 RID: 150466
		protected Dictionary<int, int> CurrentDecoration = new Dictionary<int, int>();

		// Token: 0x04024BC3 RID: 150467
		[Nullable(2)]
		private DecorationItem SpecialDecoration;
	}
}
