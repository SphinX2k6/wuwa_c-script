using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058B5 RID: 22709
	public struct ISceneItemAiType : IFlatbufferObject
	{
		// Token: 0x1700AA04 RID: 43524
		// (get) Token: 0x060264FC RID: 156924 RVA: 0x00547D32 File Offset: 0x00545F32
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060264FD RID: 156925 RVA: 0x00547D3F File Offset: 0x00545F3F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060264FE RID: 156926 RVA: 0x00547D48 File Offset: 0x00545F48
		public static ISceneItemAiType GetRootAsISceneItemAiType(ByteBuffer _bb)
		{
			return ISceneItemAiType.GetRootAsISceneItemAiType(_bb, default(ISceneItemAiType));
		}

		// Token: 0x060264FF RID: 156927 RVA: 0x00547D64 File Offset: 0x00545F64
		public static ISceneItemAiType GetRootAsISceneItemAiType(ByteBuffer _bb, ISceneItemAiType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026500 RID: 156928 RVA: 0x00547D81 File Offset: 0x00545F81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026501 RID: 156929 RVA: 0x00547D90 File Offset: 0x00545F90
		public ISceneItemAiType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AA05 RID: 43525
		// (get) Token: 0x06026502 RID: 156930 RVA: 0x00547DA0 File Offset: 0x00545FA0
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

		// Token: 0x1700AA06 RID: 43526
		// (get) Token: 0x06026503 RID: 156931 RVA: 0x00547DDC File Offset: 0x00545FDC
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

		// Token: 0x1700AA07 RID: 43527
		// (get) Token: 0x06026504 RID: 156932 RVA: 0x00547E3C File Offset: 0x0054603C
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

		// Token: 0x1700AA08 RID: 43528
		// (get) Token: 0x06026505 RID: 156933 RVA: 0x00547E9C File Offset: 0x0054609C
		public bool HideWhenDisable
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06026506 RID: 156934 RVA: 0x00547EDC File Offset: 0x005460DC
		public static Offset<ISceneItemAiType> CreateISceneItemAiType(FlatBufferBuilder builder, ESceneItemAiType Type = ESceneItemAiType.SceneItemPatrol, Offset<IConditionGroup> EnableConditionOffset = default(Offset<IConditionGroup>), Offset<IConditionGroup> DisableConditionOffset = default(Offset<IConditionGroup>), bool HideWhenDisable = false)
		{
			builder.StartTable(4);
			ISceneItemAiType.AddDisableCondition(builder, DisableConditionOffset);
			ISceneItemAiType.AddEnableCondition(builder, EnableConditionOffset);
			ISceneItemAiType.AddHideWhenDisable(builder, HideWhenDisable);
			ISceneItemAiType.AddType(builder, Type);
			return ISceneItemAiType.EndISceneItemAiType(builder);
		}

		// Token: 0x06026507 RID: 156935 RVA: 0x00547F08 File Offset: 0x00546108
		public static void StartISceneItemAiType(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06026508 RID: 156936 RVA: 0x00547F11 File Offset: 0x00546111
		public static void AddType(FlatBufferBuilder builder, ESceneItemAiType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026509 RID: 156937 RVA: 0x00547F1C File Offset: 0x0054611C
		public static void AddEnableCondition(FlatBufferBuilder builder, Offset<IConditionGroup> enableConditionOffset)
		{
			builder.AddOffset(1, enableConditionOffset.Value, 0);
		}

		// Token: 0x0602650A RID: 156938 RVA: 0x00547F2C File Offset: 0x0054612C
		public static void AddDisableCondition(FlatBufferBuilder builder, Offset<IConditionGroup> disableConditionOffset)
		{
			builder.AddOffset(2, disableConditionOffset.Value, 0);
		}

		// Token: 0x0602650B RID: 156939 RVA: 0x00547F3C File Offset: 0x0054613C
		public static void AddHideWhenDisable(FlatBufferBuilder builder, bool hideWhenDisable)
		{
			builder.AddBool(3, hideWhenDisable, false);
		}

		// Token: 0x0602650C RID: 156940 RVA: 0x00547F47 File Offset: 0x00546147
		public static Offset<ISceneItemAiType> EndISceneItemAiType(FlatBufferBuilder builder)
		{
			return new Offset<ISceneItemAiType>(builder.EndTable());
		}

		// Token: 0x0602650D RID: 156941 RVA: 0x00547F54 File Offset: 0x00546154
		public ISceneItemAiTypeT UnPack()
		{
			ISceneItemAiTypeT sceneItemAiTypeT = new ISceneItemAiTypeT();
			this.UnPackTo(sceneItemAiTypeT);
			return sceneItemAiTypeT;
		}

		// Token: 0x0602650E RID: 156942 RVA: 0x00547F70 File Offset: 0x00546170
		public void UnPackTo(ISceneItemAiTypeT _o)
		{
			_o.Type = this.Type;
			_o.EnableCondition = ((this.EnableCondition != null) ? this.EnableCondition.Value.UnPack() : null);
			_o.DisableCondition = ((this.DisableCondition != null) ? this.DisableCondition.Value.UnPack() : null);
			_o.HideWhenDisable = this.HideWhenDisable;
		}

		// Token: 0x0602650F RID: 156943 RVA: 0x00547FF4 File Offset: 0x005461F4
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

		// Token: 0x0400EE23 RID: 60963
		private Table __p;
	}
}
