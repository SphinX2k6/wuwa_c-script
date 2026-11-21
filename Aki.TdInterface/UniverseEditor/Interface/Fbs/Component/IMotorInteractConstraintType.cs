using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B5E RID: 23390
	public struct IMotorInteractConstraintType : IFlatbufferObject
	{
		// Token: 0x1700AAC5 RID: 43717
		// (get) Token: 0x060267EA RID: 157674 RVA: 0x00545823 File Offset: 0x00543A23
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060267EB RID: 157675 RVA: 0x00545830 File Offset: 0x00543A30
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060267EC RID: 157676 RVA: 0x00545838 File Offset: 0x00543A38
		public static IMotorInteractConstraintType GetRootAsIMotorInteractConstraintType(ByteBuffer _bb)
		{
			return IMotorInteractConstraintType.GetRootAsIMotorInteractConstraintType(_bb, default(IMotorInteractConstraintType));
		}

		// Token: 0x060267ED RID: 157677 RVA: 0x00545854 File Offset: 0x00543A54
		public static IMotorInteractConstraintType GetRootAsIMotorInteractConstraintType(ByteBuffer _bb, IMotorInteractConstraintType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060267EE RID: 157678 RVA: 0x00545871 File Offset: 0x00543A71
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060267EF RID: 157679 RVA: 0x00545880 File Offset: 0x00543A80
		public IMotorInteractConstraintType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AAC6 RID: 43718
		// (get) Token: 0x060267F0 RID: 157680 RVA: 0x00545890 File Offset: 0x00543A90
		public EMotorInteractConstraintType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMotorInteractConstraintType.FaceToTarget;
				}
				return (EMotorInteractConstraintType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060267F1 RID: 157681 RVA: 0x005458CC File Offset: 0x00543ACC
		public static Offset<IMotorInteractConstraintType> CreateIMotorInteractConstraintType(FlatBufferBuilder builder, EMotorInteractConstraintType Type = EMotorInteractConstraintType.FaceToTarget)
		{
			builder.StartTable(1);
			IMotorInteractConstraintType.AddType(builder, Type);
			return IMotorInteractConstraintType.EndIMotorInteractConstraintType(builder);
		}

		// Token: 0x060267F2 RID: 157682 RVA: 0x005458E2 File Offset: 0x00543AE2
		public static void StartIMotorInteractConstraintType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060267F3 RID: 157683 RVA: 0x005458EB File Offset: 0x00543AEB
		public static void AddType(FlatBufferBuilder builder, EMotorInteractConstraintType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060267F4 RID: 157684 RVA: 0x005458F6 File Offset: 0x00543AF6
		public static Offset<IMotorInteractConstraintType> EndIMotorInteractConstraintType(FlatBufferBuilder builder)
		{
			return new Offset<IMotorInteractConstraintType>(builder.EndTable());
		}

		// Token: 0x060267F5 RID: 157685 RVA: 0x00545904 File Offset: 0x00543B04
		public IMotorInteractConstraintTypeT UnPack()
		{
			IMotorInteractConstraintTypeT motorInteractConstraintTypeT = new IMotorInteractConstraintTypeT();
			this.UnPackTo(motorInteractConstraintTypeT);
			return motorInteractConstraintTypeT;
		}

		// Token: 0x060267F6 RID: 157686 RVA: 0x0054591F File Offset: 0x00543B1F
		public void UnPackTo(IMotorInteractConstraintTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060267F7 RID: 157687 RVA: 0x00545930 File Offset: 0x00543B30
		public static Offset<IMotorInteractConstraintType> Pack(FlatBufferBuilder builder, IMotorInteractConstraintTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMotorInteractConstraintType>);
			}
			return IMotorInteractConstraintType.CreateIMotorInteractConstraintType(builder, _o.Type);
		}

		// Token: 0x0400F569 RID: 62825
		private Table __p;
	}
}
