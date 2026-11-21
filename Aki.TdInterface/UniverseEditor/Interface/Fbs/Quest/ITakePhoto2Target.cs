using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045E6 RID: 17894
	public struct ITakePhoto2Target : IFlatbufferObject
	{
		// Token: 0x17007D29 RID: 32041
		// (get) Token: 0x0601A247 RID: 107079 RVA: 0x003B9677 File Offset: 0x003B7877
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A248 RID: 107080 RVA: 0x003B9684 File Offset: 0x003B7884
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A249 RID: 107081 RVA: 0x003B968C File Offset: 0x003B788C
		public static ITakePhoto2Target GetRootAsITakePhoto2Target(ByteBuffer _bb)
		{
			return ITakePhoto2Target.GetRootAsITakePhoto2Target(_bb, default(ITakePhoto2Target));
		}

		// Token: 0x0601A24A RID: 107082 RVA: 0x003B96A8 File Offset: 0x003B78A8
		public static ITakePhoto2Target GetRootAsITakePhoto2Target(ByteBuffer _bb, ITakePhoto2Target obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A24B RID: 107083 RVA: 0x003B96C5 File Offset: 0x003B78C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A24C RID: 107084 RVA: 0x003B96D4 File Offset: 0x003B78D4
		public ITakePhoto2Target __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007D2A RID: 32042
		// (get) Token: 0x0601A24D RID: 107085 RVA: 0x003B96E4 File Offset: 0x003B78E4
		public ETakePhoto2TargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETakePhoto2TargetType.Entity;
				}
				return (ETakePhoto2TargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007D2B RID: 32043
		// (get) Token: 0x0601A24E RID: 107086 RVA: 0x003B9720 File Offset: 0x003B7920
		public bool IsOptionalTarget
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007D2C RID: 32044
		// (get) Token: 0x0601A24F RID: 107087 RVA: 0x003B9760 File Offset: 0x003B7960
		public ITakePhoto2TargetCameraDistanceCondition? TargetCameraDistanceCondition
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new ITakePhoto2TargetCameraDistanceCondition?(default(ITakePhoto2TargetCameraDistanceCondition).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007D2D RID: 32045
		// (get) Token: 0x0601A250 RID: 107088 RVA: 0x003B97C0 File Offset: 0x003B79C0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601A251 RID: 107089 RVA: 0x003B97FD File Offset: 0x003B79FD
		public static Offset<ITakePhoto2Target> CreateITakePhoto2Target(FlatBufferBuilder builder, ETakePhoto2TargetType Type = ETakePhoto2TargetType.Entity, bool IsOptionalTarget = false, Offset<ITakePhoto2TargetCameraDistanceCondition> TargetCameraDistanceConditionOffset = default(Offset<ITakePhoto2TargetCameraDistanceCondition>), byte NullMask = 0)
		{
			builder.StartTable(4);
			ITakePhoto2Target.AddTargetCameraDistanceCondition(builder, TargetCameraDistanceConditionOffset);
			ITakePhoto2Target.AddNullMask(builder, NullMask);
			ITakePhoto2Target.AddIsOptionalTarget(builder, IsOptionalTarget);
			ITakePhoto2Target.AddType(builder, Type);
			return ITakePhoto2Target.EndITakePhoto2Target(builder);
		}

		// Token: 0x0601A252 RID: 107090 RVA: 0x003B9829 File Offset: 0x003B7A29
		public static void StartITakePhoto2Target(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601A253 RID: 107091 RVA: 0x003B9832 File Offset: 0x003B7A32
		public static void AddType(FlatBufferBuilder builder, ETakePhoto2TargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A254 RID: 107092 RVA: 0x003B983D File Offset: 0x003B7A3D
		public static void AddIsOptionalTarget(FlatBufferBuilder builder, bool isOptionalTarget)
		{
			builder.AddBool(1, isOptionalTarget, false);
		}

		// Token: 0x0601A255 RID: 107093 RVA: 0x003B9848 File Offset: 0x003B7A48
		public static void AddTargetCameraDistanceCondition(FlatBufferBuilder builder, Offset<ITakePhoto2TargetCameraDistanceCondition> targetCameraDistanceConditionOffset)
		{
			builder.AddOffset(2, targetCameraDistanceConditionOffset.Value, 0);
		}

		// Token: 0x0601A256 RID: 107094 RVA: 0x003B9858 File Offset: 0x003B7A58
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0601A257 RID: 107095 RVA: 0x003B9863 File Offset: 0x003B7A63
		public static Offset<ITakePhoto2Target> EndITakePhoto2Target(FlatBufferBuilder builder)
		{
			return new Offset<ITakePhoto2Target>(builder.EndTable());
		}

		// Token: 0x0601A258 RID: 107096 RVA: 0x003B9870 File Offset: 0x003B7A70
		public ITakePhoto2TargetT UnPack()
		{
			ITakePhoto2TargetT takePhoto2TargetT = new ITakePhoto2TargetT();
			this.UnPackTo(takePhoto2TargetT);
			return takePhoto2TargetT;
		}

		// Token: 0x0601A259 RID: 107097 RVA: 0x003B988C File Offset: 0x003B7A8C
		public void UnPackTo(ITakePhoto2TargetT _o)
		{
			_o.Type = this.Type;
			_o.IsOptionalTarget = this.IsOptionalTarget;
			_o.TargetCameraDistanceCondition = ((this.TargetCameraDistanceCondition != null) ? this.TargetCameraDistanceCondition.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601A25A RID: 107098 RVA: 0x003B98EC File Offset: 0x003B7AEC
		public static Offset<ITakePhoto2Target> Pack(FlatBufferBuilder builder, ITakePhoto2TargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITakePhoto2Target>);
			}
			Offset<ITakePhoto2TargetCameraDistanceCondition> targetCameraDistanceConditionOffset = (_o.TargetCameraDistanceCondition == null) ? default(Offset<ITakePhoto2TargetCameraDistanceCondition>) : ITakePhoto2TargetCameraDistanceCondition.Pack(builder, _o.TargetCameraDistanceCondition);
			return ITakePhoto2Target.CreateITakePhoto2Target(builder, _o.Type, _o.IsOptionalTarget, targetCameraDistanceConditionOffset, _o.NullMask);
		}

		// Token: 0x0400C7CA RID: 51146
		private Table __p;
	}
}
