using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200452F RID: 17711
	public struct IRollBlockLaunchMethodRange : IFlatbufferObject
	{
		// Token: 0x17007B2E RID: 31534
		// (get) Token: 0x06019A36 RID: 105014 RVA: 0x003A6D72 File Offset: 0x003A4F72
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019A37 RID: 105015 RVA: 0x003A6D7F File Offset: 0x003A4F7F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019A38 RID: 105016 RVA: 0x003A6D88 File Offset: 0x003A4F88
		public static IRollBlockLaunchMethodRange GetRootAsIRollBlockLaunchMethodRange(ByteBuffer _bb)
		{
			return IRollBlockLaunchMethodRange.GetRootAsIRollBlockLaunchMethodRange(_bb, default(IRollBlockLaunchMethodRange));
		}

		// Token: 0x06019A39 RID: 105017 RVA: 0x003A6DA4 File Offset: 0x003A4FA4
		public static IRollBlockLaunchMethodRange GetRootAsIRollBlockLaunchMethodRange(ByteBuffer _bb, IRollBlockLaunchMethodRange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019A3A RID: 105018 RVA: 0x003A6DC1 File Offset: 0x003A4FC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019A3B RID: 105019 RVA: 0x003A6DD0 File Offset: 0x003A4FD0
		public IRollBlockLaunchMethodRange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007B2F RID: 31535
		// (get) Token: 0x06019A3C RID: 105020 RVA: 0x003A6DE0 File Offset: 0x003A4FE0
		public ERollBlockLaunchMethod Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERollBlockLaunchMethod.Interact;
				}
				return (ERollBlockLaunchMethod)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007B30 RID: 31536
		// (get) Token: 0x06019A3D RID: 105021 RVA: 0x003A6E1C File Offset: 0x003A501C
		public int TargetId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06019A3E RID: 105022 RVA: 0x003A6E58 File Offset: 0x003A5058
		public static Offset<IRollBlockLaunchMethodRange> CreateIRollBlockLaunchMethodRange(FlatBufferBuilder builder, ERollBlockLaunchMethod Type = ERollBlockLaunchMethod.Interact, int TargetId = 0)
		{
			builder.StartTable(2);
			IRollBlockLaunchMethodRange.AddTargetId(builder, TargetId);
			IRollBlockLaunchMethodRange.AddType(builder, Type);
			return IRollBlockLaunchMethodRange.EndIRollBlockLaunchMethodRange(builder);
		}

		// Token: 0x06019A3F RID: 105023 RVA: 0x003A6E75 File Offset: 0x003A5075
		public static void StartIRollBlockLaunchMethodRange(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06019A40 RID: 105024 RVA: 0x003A6E7E File Offset: 0x003A507E
		public static void AddType(FlatBufferBuilder builder, ERollBlockLaunchMethod type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019A41 RID: 105025 RVA: 0x003A6E89 File Offset: 0x003A5089
		public static void AddTargetId(FlatBufferBuilder builder, int targetId)
		{
			builder.AddInt(1, targetId, 0);
		}

		// Token: 0x06019A42 RID: 105026 RVA: 0x003A6E94 File Offset: 0x003A5094
		public static Offset<IRollBlockLaunchMethodRange> EndIRollBlockLaunchMethodRange(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlockLaunchMethodRange>(builder.EndTable());
		}

		// Token: 0x06019A43 RID: 105027 RVA: 0x003A6EA4 File Offset: 0x003A50A4
		public IRollBlockLaunchMethodRangeT UnPack()
		{
			IRollBlockLaunchMethodRangeT rollBlockLaunchMethodRangeT = new IRollBlockLaunchMethodRangeT();
			this.UnPackTo(rollBlockLaunchMethodRangeT);
			return rollBlockLaunchMethodRangeT;
		}

		// Token: 0x06019A44 RID: 105028 RVA: 0x003A6EBF File Offset: 0x003A50BF
		public void UnPackTo(IRollBlockLaunchMethodRangeT _o)
		{
			_o.Type = this.Type;
			_o.TargetId = this.TargetId;
		}

		// Token: 0x06019A45 RID: 105029 RVA: 0x003A6EDC File Offset: 0x003A50DC
		public static Offset<IRollBlockLaunchMethodRange> Pack(FlatBufferBuilder builder, IRollBlockLaunchMethodRangeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRollBlockLaunchMethodRange>);
			}
			return IRollBlockLaunchMethodRange.CreateIRollBlockLaunchMethodRange(builder, _o.Type, _o.TargetId);
		}

		// Token: 0x0400C66E RID: 50798
		private Table __p;
	}
}
