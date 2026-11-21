using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004EAB RID: 20139
	public struct ICheckEnterTriggerDirType : IFlatbufferObject
	{
		// Token: 0x17008FAE RID: 36782
		// (get) Token: 0x0601F37F RID: 127871 RVA: 0x0045A248 File Offset: 0x00458448
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F380 RID: 127872 RVA: 0x0045A255 File Offset: 0x00458455
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F381 RID: 127873 RVA: 0x0045A25C File Offset: 0x0045845C
		public static ICheckEnterTriggerDirType GetRootAsICheckEnterTriggerDirType(ByteBuffer _bb)
		{
			return ICheckEnterTriggerDirType.GetRootAsICheckEnterTriggerDirType(_bb, default(ICheckEnterTriggerDirType));
		}

		// Token: 0x0601F382 RID: 127874 RVA: 0x0045A278 File Offset: 0x00458478
		public static ICheckEnterTriggerDirType GetRootAsICheckEnterTriggerDirType(ByteBuffer _bb, ICheckEnterTriggerDirType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F383 RID: 127875 RVA: 0x0045A295 File Offset: 0x00458495
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F384 RID: 127876 RVA: 0x0045A2A4 File Offset: 0x004584A4
		public ICheckEnterTriggerDirType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008FAF RID: 36783
		// (get) Token: 0x0601F385 RID: 127877 RVA: 0x0045A2B4 File Offset: 0x004584B4
		public ECheckEnterTriggerDirType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECheckEnterTriggerDirType.ForwardAngle;
				}
				return (ECheckEnterTriggerDirType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F386 RID: 127878 RVA: 0x0045A2F0 File Offset: 0x004584F0
		public static Offset<ICheckEnterTriggerDirType> CreateICheckEnterTriggerDirType(FlatBufferBuilder builder, ECheckEnterTriggerDirType Type = ECheckEnterTriggerDirType.ForwardAngle)
		{
			builder.StartTable(1);
			ICheckEnterTriggerDirType.AddType(builder, Type);
			return ICheckEnterTriggerDirType.EndICheckEnterTriggerDirType(builder);
		}

		// Token: 0x0601F387 RID: 127879 RVA: 0x0045A306 File Offset: 0x00458506
		public static void StartICheckEnterTriggerDirType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601F388 RID: 127880 RVA: 0x0045A30F File Offset: 0x0045850F
		public static void AddType(FlatBufferBuilder builder, ECheckEnterTriggerDirType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F389 RID: 127881 RVA: 0x0045A31A File Offset: 0x0045851A
		public static Offset<ICheckEnterTriggerDirType> EndICheckEnterTriggerDirType(FlatBufferBuilder builder)
		{
			return new Offset<ICheckEnterTriggerDirType>(builder.EndTable());
		}

		// Token: 0x0601F38A RID: 127882 RVA: 0x0045A328 File Offset: 0x00458528
		public ICheckEnterTriggerDirTypeT UnPack()
		{
			ICheckEnterTriggerDirTypeT checkEnterTriggerDirTypeT = new ICheckEnterTriggerDirTypeT();
			this.UnPackTo(checkEnterTriggerDirTypeT);
			return checkEnterTriggerDirTypeT;
		}

		// Token: 0x0601F38B RID: 127883 RVA: 0x0045A343 File Offset: 0x00458543
		public void UnPackTo(ICheckEnterTriggerDirTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601F38C RID: 127884 RVA: 0x0045A354 File Offset: 0x00458554
		public static Offset<ICheckEnterTriggerDirType> Pack(FlatBufferBuilder builder, ICheckEnterTriggerDirTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckEnterTriggerDirType>);
			}
			return ICheckEnterTriggerDirType.CreateICheckEnterTriggerDirType(builder, _o.Type);
		}

		// Token: 0x0400DCF2 RID: 56562
		private Table __p;
	}
}
