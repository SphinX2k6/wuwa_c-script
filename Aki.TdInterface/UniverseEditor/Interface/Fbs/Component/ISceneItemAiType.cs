using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005EC2 RID: 24258
	public struct ISceneItemAiType : IFlatbufferObject
	{
		// Token: 0x1700B334 RID: 45876
		// (get) Token: 0x06028A5E RID: 166494 RVA: 0x0058E87E File Offset: 0x0058CA7E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028A5F RID: 166495 RVA: 0x0058E88B File Offset: 0x0058CA8B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028A60 RID: 166496 RVA: 0x0058E894 File Offset: 0x0058CA94
		public static ISceneItemAiType GetRootAsISceneItemAiType(ByteBuffer _bb)
		{
			return ISceneItemAiType.GetRootAsISceneItemAiType(_bb, default(ISceneItemAiType));
		}

		// Token: 0x06028A61 RID: 166497 RVA: 0x0058E8B0 File Offset: 0x0058CAB0
		public static ISceneItemAiType GetRootAsISceneItemAiType(ByteBuffer _bb, ISceneItemAiType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028A62 RID: 166498 RVA: 0x0058E8CD File Offset: 0x0058CACD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028A63 RID: 166499 RVA: 0x0058E8DC File Offset: 0x0058CADC
		public ISceneItemAiType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B335 RID: 45877
		// (get) Token: 0x06028A64 RID: 166500 RVA: 0x0058E8EC File Offset: 0x0058CAEC
		public ESceneItemAiType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESceneItemAiType.SceneItemPatrol;
				}
				return (ESceneItemAiType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B336 RID: 45878
		// (get) Token: 0x06028A65 RID: 166501 RVA: 0x0058E928 File Offset: 0x0058CB28
		public IConditionGroup? EnableCondition
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B337 RID: 45879
		// (get) Token: 0x06028A66 RID: 166502 RVA: 0x0058E988 File Offset: 0x0058CB88
		public IConditionGroup? DisableCondition
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B338 RID: 45880
		// (get) Token: 0x06028A67 RID: 166503 RVA: 0x0058E9E8 File Offset: 0x0058CBE8
		public bool HideWhenDisable
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06028A68 RID: 166504 RVA: 0x0058EA28 File Offset: 0x0058CC28
		public static Offset<ISceneItemAiType> CreateISceneItemAiType(FlatBufferBuilder builder, ESceneItemAiType Type = ESceneItemAiType.SceneItemPatrol, Offset<IConditionGroup> EnableConditionOffset = default(Offset<IConditionGroup>), Offset<IConditionGroup> DisableConditionOffset = default(Offset<IConditionGroup>), bool HideWhenDisable = false)
		{
			builder.StartTable(4);
			ISceneItemAiType.AddDisableCondition(builder, DisableConditionOffset);
			ISceneItemAiType.AddEnableCondition(builder, EnableConditionOffset);
			ISceneItemAiType.AddHideWhenDisable(builder, HideWhenDisable);
			ISceneItemAiType.AddType(builder, Type);
			return ISceneItemAiType.EndISceneItemAiType(builder);
		}

		// Token: 0x06028A69 RID: 166505 RVA: 0x0058EA54 File Offset: 0x0058CC54
		public static void StartISceneItemAiType(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06028A6A RID: 166506 RVA: 0x0058EA5D File Offset: 0x0058CC5D
		public static void AddType(FlatBufferBuilder builder, ESceneItemAiType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06028A6B RID: 166507 RVA: 0x0058EA68 File Offset: 0x0058CC68
		public static void AddEnableCondition(FlatBufferBuilder builder, Offset<IConditionGroup> enableConditionOffset)
		{
			builder.AddOffset(1, enableConditionOffset.Value, 0);
		}

		// Token: 0x06028A6C RID: 166508 RVA: 0x0058EA78 File Offset: 0x0058CC78
		public static void AddDisableCondition(FlatBufferBuilder builder, Offset<IConditionGroup> disableConditionOffset)
		{
			builder.AddOffset(2, disableConditionOffset.Value, 0);
		}

		// Token: 0x06028A6D RID: 166509 RVA: 0x0058EA88 File Offset: 0x0058CC88
		public static void AddHideWhenDisable(FlatBufferBuilder builder, bool hideWhenDisable)
		{
			builder.AddBool(3, hideWhenDisable, false);
		}

		// Token: 0x06028A6E RID: 166510 RVA: 0x0058EA93 File Offset: 0x0058CC93
		public static Offset<ISceneItemAiType> EndISceneItemAiType(FlatBufferBuilder builder)
		{
			return new Offset<ISceneItemAiType>(builder.EndTable());
		}

		// Token: 0x06028A6F RID: 166511 RVA: 0x0058EAA0 File Offset: 0x0058CCA0
		public ISceneItemAiTypeT UnPack()
		{
			ISceneItemAiTypeT sceneItemAiTypeT = new ISceneItemAiTypeT();
			this.UnPackTo(sceneItemAiTypeT);
			return sceneItemAiTypeT;
		}

		// Token: 0x06028A70 RID: 166512 RVA: 0x0058EABC File Offset: 0x0058CCBC
		public void UnPackTo(ISceneItemAiTypeT _o)
		{
			_o.Type = this.Type;
			_o.EnableCondition = ((this.EnableCondition != null) ? this.EnableCondition.Value.UnPack() : null);
			_o.DisableCondition = ((this.DisableCondition != null) ? this.DisableCondition.Value.UnPack() : null);
			_o.HideWhenDisable = this.HideWhenDisable;
		}

		// Token: 0x06028A71 RID: 166513 RVA: 0x0058EB40 File Offset: 0x0058CD40
		public static Offset<ISceneItemAiType> Pack(FlatBufferBuilder builder, ISceneItemAiTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISceneItemAiType>);
			}
			Offset<IConditionGroup> enableConditionOffset = (_o.EnableCondition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.EnableCondition);
			Offset<IConditionGroup> disableConditionOffset = (_o.DisableCondition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.DisableCondition);
			return ISceneItemAiType.CreateISceneItemAiType(builder, _o.Type, enableConditionOffset, disableConditionOffset, _o.HideWhenDisable);
		}

		// Token: 0x0400FB16 RID: 64278
		private Table __p;
	}
}
