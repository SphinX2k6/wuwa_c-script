using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A9C RID: 19100
	public struct ICheckIsSupportedWalking : IFlatbufferObject
	{
		// Token: 0x17008A64 RID: 35428
		// (get) Token: 0x0601DF64 RID: 122724 RVA: 0x00434F11 File Offset: 0x00433111
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DF65 RID: 122725 RVA: 0x00434F1E File Offset: 0x0043311E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DF66 RID: 122726 RVA: 0x00434F28 File Offset: 0x00433128
		public static ICheckIsSupportedWalking GetRootAsICheckIsSupportedWalking(ByteBuffer _bb)
		{
			return ICheckIsSupportedWalking.GetRootAsICheckIsSupportedWalking(_bb, default(ICheckIsSupportedWalking));
		}

		// Token: 0x0601DF67 RID: 122727 RVA: 0x00434F44 File Offset: 0x00433144
		public static ICheckIsSupportedWalking GetRootAsICheckIsSupportedWalking(ByteBuffer _bb, ICheckIsSupportedWalking obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DF68 RID: 122728 RVA: 0x00434F61 File Offset: 0x00433161
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DF69 RID: 122729 RVA: 0x00434F70 File Offset: 0x00433170
		public ICheckIsSupportedWalking __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008A65 RID: 35429
		// (get) Token: 0x0601DF6A RID: 122730 RVA: 0x00434F80 File Offset: 0x00433180
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008A66 RID: 35430
		// (get) Token: 0x0601DF6B RID: 122731 RVA: 0x00434FBC File Offset: 0x004331BC
		public bool IsSupported
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601DF6C RID: 122732 RVA: 0x00434FFB File Offset: 0x004331FB
		public static Offset<ICheckIsSupportedWalking> CreateICheckIsSupportedWalking(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, bool IsSupported = false)
		{
			builder.StartTable(2);
			ICheckIsSupportedWalking.AddIsSupported(builder, IsSupported);
			ICheckIsSupportedWalking.AddType(builder, Type);
			return ICheckIsSupportedWalking.EndICheckIsSupportedWalking(builder);
		}

		// Token: 0x0601DF6D RID: 122733 RVA: 0x00435018 File Offset: 0x00433218
		public static void StartICheckIsSupportedWalking(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601DF6E RID: 122734 RVA: 0x00435021 File Offset: 0x00433221
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601DF6F RID: 122735 RVA: 0x0043502C File Offset: 0x0043322C
		public static void AddIsSupported(FlatBufferBuilder builder, bool isSupported)
		{
			builder.AddBool(1, isSupported, false);
		}

		// Token: 0x0601DF70 RID: 122736 RVA: 0x00435037 File Offset: 0x00433237
		public static Offset<ICheckIsSupportedWalking> EndICheckIsSupportedWalking(FlatBufferBuilder builder)
		{
			return new Offset<ICheckIsSupportedWalking>(builder.EndTable());
		}

		// Token: 0x0601DF71 RID: 122737 RVA: 0x00435044 File Offset: 0x00433244
		public ICheckIsSupportedWalkingT UnPack()
		{
			ICheckIsSupportedWalkingT checkIsSupportedWalkingT = new ICheckIsSupportedWalkingT();
			this.UnPackTo(checkIsSupportedWalkingT);
			return checkIsSupportedWalkingT;
		}

		// Token: 0x0601DF72 RID: 122738 RVA: 0x0043505F File Offset: 0x0043325F
		public void UnPackTo(ICheckIsSupportedWalkingT _o)
		{
			_o.Type = this.Type;
			_o.IsSupported = this.IsSupported;
		}

		// Token: 0x0601DF73 RID: 122739 RVA: 0x0043507C File Offset: 0x0043327C
		public static Offset<ICheckIsSupportedWalking> Pack(FlatBufferBuilder builder, ICheckIsSupportedWalkingT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckIsSupportedWalking>);
			}
			return ICheckIsSupportedWalking.CreateICheckIsSupportedWalking(builder, _o.Type, _o.IsSupported);
		}

		// Token: 0x0400D30F RID: 54031
		private Table __p;
	}
}
