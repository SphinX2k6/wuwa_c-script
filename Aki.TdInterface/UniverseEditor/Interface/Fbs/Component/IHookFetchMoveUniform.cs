using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053BC RID: 21436
	public struct IHookFetchMoveUniform : IFlatbufferObject
	{
		// Token: 0x17009D8C RID: 40332
		// (get) Token: 0x0602320A RID: 143882 RVA: 0x004DCD5A File Offset: 0x004DAF5A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602320B RID: 143883 RVA: 0x004DCD67 File Offset: 0x004DAF67
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602320C RID: 143884 RVA: 0x004DCD70 File Offset: 0x004DAF70
		public static IHookFetchMoveUniform GetRootAsIHookFetchMoveUniform(ByteBuffer _bb)
		{
			return IHookFetchMoveUniform.GetRootAsIHookFetchMoveUniform(_bb, default(IHookFetchMoveUniform));
		}

		// Token: 0x0602320D RID: 143885 RVA: 0x004DCD8C File Offset: 0x004DAF8C
		public static IHookFetchMoveUniform GetRootAsIHookFetchMoveUniform(ByteBuffer _bb, IHookFetchMoveUniform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602320E RID: 143886 RVA: 0x004DCDA9 File Offset: 0x004DAFA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602320F RID: 143887 RVA: 0x004DCDB8 File Offset: 0x004DAFB8
		public IHookFetchMoveUniform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009D8D RID: 40333
		// (get) Token: 0x06023210 RID: 143888 RVA: 0x004DCDC8 File Offset: 0x004DAFC8
		public EHookFetchMoveMode Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EHookFetchMoveMode.Uniform;
				}
				return (EHookFetchMoveMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009D8E RID: 40334
		// (get) Token: 0x06023211 RID: 143889 RVA: 0x004DCE04 File Offset: 0x004DB004
		public float Speed
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023212 RID: 143890 RVA: 0x004DCE44 File Offset: 0x004DB044
		public static Offset<IHookFetchMoveUniform> CreateIHookFetchMoveUniform(FlatBufferBuilder builder, EHookFetchMoveMode Type = EHookFetchMoveMode.Uniform, float Speed = 0f)
		{
			builder.StartTable(2);
			IHookFetchMoveUniform.AddSpeed(builder, Speed);
			IHookFetchMoveUniform.AddType(builder, Type);
			return IHookFetchMoveUniform.EndIHookFetchMoveUniform(builder);
		}

		// Token: 0x06023213 RID: 143891 RVA: 0x004DCE61 File Offset: 0x004DB061
		public static void StartIHookFetchMoveUniform(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06023214 RID: 143892 RVA: 0x004DCE6A File Offset: 0x004DB06A
		public static void AddType(FlatBufferBuilder builder, EHookFetchMoveMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06023215 RID: 143893 RVA: 0x004DCE75 File Offset: 0x004DB075
		public static void AddSpeed(FlatBufferBuilder builder, float speed)
		{
			builder.AddFloat(1, speed, 0.0);
		}

		// Token: 0x06023216 RID: 143894 RVA: 0x004DCE88 File Offset: 0x004DB088
		public static Offset<IHookFetchMoveUniform> EndIHookFetchMoveUniform(FlatBufferBuilder builder)
		{
			return new Offset<IHookFetchMoveUniform>(builder.EndTable());
		}

		// Token: 0x06023217 RID: 143895 RVA: 0x004DCE98 File Offset: 0x004DB098
		public IHookFetchMoveUniformT UnPack()
		{
			IHookFetchMoveUniformT hookFetchMoveUniformT = new IHookFetchMoveUniformT();
			this.UnPackTo(hookFetchMoveUniformT);
			return hookFetchMoveUniformT;
		}

		// Token: 0x06023218 RID: 143896 RVA: 0x004DCEB3 File Offset: 0x004DB0B3
		public void UnPackTo(IHookFetchMoveUniformT _o)
		{
			_o.Type = this.Type;
			_o.Speed = this.Speed;
		}

		// Token: 0x06023219 RID: 143897 RVA: 0x004DCED0 File Offset: 0x004DB0D0
		public static Offset<IHookFetchMoveUniform> Pack(FlatBufferBuilder builder, IHookFetchMoveUniformT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHookFetchMoveUniform>);
			}
			return IHookFetchMoveUniform.CreateIHookFetchMoveUniform(builder, _o.Type, _o.Speed);
		}

		// Token: 0x0400E5BE RID: 58814
		private Table __p;
	}
}
