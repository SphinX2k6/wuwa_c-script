using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200761B RID: 30235
	public struct IResetPlayerFocusType : IFlatbufferObject
	{
		// Token: 0x1700DE26 RID: 56870
		// (get) Token: 0x060350D9 RID: 217305 RVA: 0x0072053C File Offset: 0x0071E73C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060350DA RID: 217306 RVA: 0x00720549 File Offset: 0x0071E749
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060350DB RID: 217307 RVA: 0x00720550 File Offset: 0x0071E750
		public static IResetPlayerFocusType GetRootAsIResetPlayerFocusType(ByteBuffer _bb)
		{
			return IResetPlayerFocusType.GetRootAsIResetPlayerFocusType(_bb, default(IResetPlayerFocusType));
		}

		// Token: 0x060350DC RID: 217308 RVA: 0x0072056C File Offset: 0x0071E76C
		public static IResetPlayerFocusType GetRootAsIResetPlayerFocusType(ByteBuffer _bb, IResetPlayerFocusType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060350DD RID: 217309 RVA: 0x00720589 File Offset: 0x0071E789
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060350DE RID: 217310 RVA: 0x00720598 File Offset: 0x0071E798
		public IResetPlayerFocusType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DE27 RID: 56871
		// (get) Token: 0x060350DF RID: 217311 RVA: 0x007205A8 File Offset: 0x0071E7A8
		public EResetPlayerFocusType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EResetPlayerFocusType.ResetToDefaultDirection;
				}
				return (EResetPlayerFocusType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060350E0 RID: 217312 RVA: 0x007205E4 File Offset: 0x0071E7E4
		public static Offset<IResetPlayerFocusType> CreateIResetPlayerFocusType(FlatBufferBuilder builder, EResetPlayerFocusType Type = EResetPlayerFocusType.ResetToDefaultDirection)
		{
			builder.StartTable(1);
			IResetPlayerFocusType.AddType(builder, Type);
			return IResetPlayerFocusType.EndIResetPlayerFocusType(builder);
		}

		// Token: 0x060350E1 RID: 217313 RVA: 0x007205FA File Offset: 0x0071E7FA
		public static void StartIResetPlayerFocusType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060350E2 RID: 217314 RVA: 0x00720603 File Offset: 0x0071E803
		public static void AddType(FlatBufferBuilder builder, EResetPlayerFocusType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060350E3 RID: 217315 RVA: 0x0072060E File Offset: 0x0071E80E
		public static Offset<IResetPlayerFocusType> EndIResetPlayerFocusType(FlatBufferBuilder builder)
		{
			return new Offset<IResetPlayerFocusType>(builder.EndTable());
		}

		// Token: 0x060350E4 RID: 217316 RVA: 0x0072061C File Offset: 0x0071E81C
		public IResetPlayerFocusTypeT UnPack()
		{
			IResetPlayerFocusTypeT resetPlayerFocusTypeT = new IResetPlayerFocusTypeT();
			this.UnPackTo(resetPlayerFocusTypeT);
			return resetPlayerFocusTypeT;
		}

		// Token: 0x060350E5 RID: 217317 RVA: 0x00720637 File Offset: 0x0071E837
		public void UnPackTo(IResetPlayerFocusTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060350E6 RID: 217318 RVA: 0x00720648 File Offset: 0x0071E848
		public static Offset<IResetPlayerFocusType> Pack(FlatBufferBuilder builder, IResetPlayerFocusTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IResetPlayerFocusType>);
			}
			return IResetPlayerFocusType.CreateIResetPlayerFocusType(builder, _o.Type);
		}

		// Token: 0x0401280A RID: 75786
		private Table __p;
	}
}
