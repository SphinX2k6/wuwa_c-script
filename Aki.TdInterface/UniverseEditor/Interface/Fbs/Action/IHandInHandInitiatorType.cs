using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068C1 RID: 26817
	public struct IHandInHandInitiatorType : IFlatbufferObject
	{
		// Token: 0x1700C707 RID: 50951
		// (get) Token: 0x0602EC6C RID: 191596 RVA: 0x0066267C File Offset: 0x0066087C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EC6D RID: 191597 RVA: 0x00662689 File Offset: 0x00660889
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EC6E RID: 191598 RVA: 0x00662690 File Offset: 0x00660890
		public static IHandInHandInitiatorType GetRootAsIHandInHandInitiatorType(ByteBuffer _bb)
		{
			return IHandInHandInitiatorType.GetRootAsIHandInHandInitiatorType(_bb, default(IHandInHandInitiatorType));
		}

		// Token: 0x0602EC6F RID: 191599 RVA: 0x006626AC File Offset: 0x006608AC
		public static IHandInHandInitiatorType GetRootAsIHandInHandInitiatorType(ByteBuffer _bb, IHandInHandInitiatorType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EC70 RID: 191600 RVA: 0x006626C9 File Offset: 0x006608C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EC71 RID: 191601 RVA: 0x006626D8 File Offset: 0x006608D8
		public IHandInHandInitiatorType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C708 RID: 50952
		// (get) Token: 0x0602EC72 RID: 191602 RVA: 0x006626E8 File Offset: 0x006608E8
		public EHandInHandInitiatorType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EHandInHandInitiatorType.Player;
				}
				return (EHandInHandInitiatorType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602EC73 RID: 191603 RVA: 0x00662724 File Offset: 0x00660924
		public static Offset<IHandInHandInitiatorType> CreateIHandInHandInitiatorType(FlatBufferBuilder builder, EHandInHandInitiatorType Type = EHandInHandInitiatorType.Player)
		{
			builder.StartTable(1);
			IHandInHandInitiatorType.AddType(builder, Type);
			return IHandInHandInitiatorType.EndIHandInHandInitiatorType(builder);
		}

		// Token: 0x0602EC74 RID: 191604 RVA: 0x0066273A File Offset: 0x0066093A
		public static void StartIHandInHandInitiatorType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602EC75 RID: 191605 RVA: 0x00662743 File Offset: 0x00660943
		public static void AddType(FlatBufferBuilder builder, EHandInHandInitiatorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602EC76 RID: 191606 RVA: 0x0066274E File Offset: 0x0066094E
		public static Offset<IHandInHandInitiatorType> EndIHandInHandInitiatorType(FlatBufferBuilder builder)
		{
			return new Offset<IHandInHandInitiatorType>(builder.EndTable());
		}

		// Token: 0x0602EC77 RID: 191607 RVA: 0x0066275C File Offset: 0x0066095C
		public IHandInHandInitiatorTypeT UnPack()
		{
			IHandInHandInitiatorTypeT handInHandInitiatorTypeT = new IHandInHandInitiatorTypeT();
			this.UnPackTo(handInHandInitiatorTypeT);
			return handInHandInitiatorTypeT;
		}

		// Token: 0x0602EC78 RID: 191608 RVA: 0x00662777 File Offset: 0x00660977
		public void UnPackTo(IHandInHandInitiatorTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602EC79 RID: 191609 RVA: 0x00662788 File Offset: 0x00660988
		public static Offset<IHandInHandInitiatorType> Pack(FlatBufferBuilder builder, IHandInHandInitiatorTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHandInHandInitiatorType>);
			}
			return IHandInHandInitiatorType.CreateIHandInHandInitiatorType(builder, _o.Type);
		}

		// Token: 0x0401101C RID: 69660
		private Table __p;
	}
}
