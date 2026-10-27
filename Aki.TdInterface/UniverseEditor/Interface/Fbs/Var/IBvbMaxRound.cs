using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A66 RID: 14950
	public struct IBvbMaxRound : IFlatbufferObject
	{
		// Token: 0x17006678 RID: 26232
		// (get) Token: 0x0601443F RID: 83007 RVA: 0x002F5E31 File Offset: 0x002F4031
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014440 RID: 83008 RVA: 0x002F5E3E File Offset: 0x002F403E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014441 RID: 83009 RVA: 0x002F5E48 File Offset: 0x002F4048
		public static IBvbMaxRound GetRootAsIBvbMaxRound(ByteBuffer _bb)
		{
			return IBvbMaxRound.GetRootAsIBvbMaxRound(_bb, default(IBvbMaxRound));
		}

		// Token: 0x06014442 RID: 83010 RVA: 0x002F5E64 File Offset: 0x002F4064
		public static IBvbMaxRound GetRootAsIBvbMaxRound(ByteBuffer _bb, IBvbMaxRound obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014443 RID: 83011 RVA: 0x002F5E81 File Offset: 0x002F4081
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014444 RID: 83012 RVA: 0x002F5E90 File Offset: 0x002F4090
		public IBvbMaxRound __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006679 RID: 26233
		// (get) Token: 0x06014445 RID: 83013 RVA: 0x002F5EA0 File Offset: 0x002F40A0
		public ESystemVarName Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESystemVarName.CommonHotFixVar;
				}
				return (ESystemVarName)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06014446 RID: 83014 RVA: 0x002F5EDC File Offset: 0x002F40DC
		public static Offset<IBvbMaxRound> CreateIBvbMaxRound(FlatBufferBuilder builder, ESystemVarName Type = ESystemVarName.CommonHotFixVar)
		{
			builder.StartTable(1);
			IBvbMaxRound.AddType(builder, Type);
			return IBvbMaxRound.EndIBvbMaxRound(builder);
		}

		// Token: 0x06014447 RID: 83015 RVA: 0x002F5EF2 File Offset: 0x002F40F2
		public static void StartIBvbMaxRound(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06014448 RID: 83016 RVA: 0x002F5EFB File Offset: 0x002F40FB
		public static void AddType(FlatBufferBuilder builder, ESystemVarName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06014449 RID: 83017 RVA: 0x002F5F06 File Offset: 0x002F4106
		public static Offset<IBvbMaxRound> EndIBvbMaxRound(FlatBufferBuilder builder)
		{
			return new Offset<IBvbMaxRound>(builder.EndTable());
		}

		// Token: 0x0601444A RID: 83018 RVA: 0x002F5F14 File Offset: 0x002F4114
		public IBvbMaxRoundT UnPack()
		{
			IBvbMaxRoundT bvbMaxRoundT = new IBvbMaxRoundT();
			this.UnPackTo(bvbMaxRoundT);
			return bvbMaxRoundT;
		}

		// Token: 0x0601444B RID: 83019 RVA: 0x002F5F2F File Offset: 0x002F412F
		public void UnPackTo(IBvbMaxRoundT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601444C RID: 83020 RVA: 0x002F5F40 File Offset: 0x002F4140
		public static Offset<IBvbMaxRound> Pack(FlatBufferBuilder builder, IBvbMaxRoundT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbMaxRound>);
			}
			return IBvbMaxRound.CreateIBvbMaxRound(builder, _o.Type);
		}

		// Token: 0x0400AEEA RID: 44778
		private Table __p;
	}
}
