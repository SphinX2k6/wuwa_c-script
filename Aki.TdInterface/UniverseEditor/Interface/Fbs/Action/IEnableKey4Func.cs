using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CE0 RID: 27872
	public struct IEnableKey4Func : IFlatbufferObject
	{
		// Token: 0x1700CC6A RID: 52330
		// (get) Token: 0x060300B2 RID: 196786 RVA: 0x00689615 File Offset: 0x00687815
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060300B3 RID: 196787 RVA: 0x00689622 File Offset: 0x00687822
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060300B4 RID: 196788 RVA: 0x0068962C File Offset: 0x0068782C
		public static IEnableKey4Func GetRootAsIEnableKey4Func(ByteBuffer _bb)
		{
			return IEnableKey4Func.GetRootAsIEnableKey4Func(_bb, default(IEnableKey4Func));
		}

		// Token: 0x060300B5 RID: 196789 RVA: 0x00689648 File Offset: 0x00687848
		public static IEnableKey4Func GetRootAsIEnableKey4Func(ByteBuffer _bb, IEnableKey4Func obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060300B6 RID: 196790 RVA: 0x00689665 File Offset: 0x00687865
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060300B7 RID: 196791 RVA: 0x00689674 File Offset: 0x00687874
		public IEnableKey4Func __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CC6B RID: 52331
		// (get) Token: 0x060300B8 RID: 196792 RVA: 0x00689684 File Offset: 0x00687884
		public bool IsEnable
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CC6C RID: 52332
		// (get) Token: 0x060300B9 RID: 196793 RVA: 0x006896C4 File Offset: 0x006878C4
		public EEnableKey4FuncKey FuncKey
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EEnableKey4FuncKey.TimeScaled;
				}
				return (EEnableKey4FuncKey)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060300BA RID: 196794 RVA: 0x00689700 File Offset: 0x00687900
		public static Offset<IEnableKey4Func> CreateIEnableKey4Func(FlatBufferBuilder builder, bool IsEnable = false, EEnableKey4FuncKey FuncKey = EEnableKey4FuncKey.TimeScaled)
		{
			builder.StartTable(2);
			IEnableKey4Func.AddFuncKey(builder, FuncKey);
			IEnableKey4Func.AddIsEnable(builder, IsEnable);
			return IEnableKey4Func.EndIEnableKey4Func(builder);
		}

		// Token: 0x060300BB RID: 196795 RVA: 0x0068971D File Offset: 0x0068791D
		public static void StartIEnableKey4Func(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060300BC RID: 196796 RVA: 0x00689726 File Offset: 0x00687926
		public static void AddIsEnable(FlatBufferBuilder builder, bool isEnable)
		{
			builder.AddBool(0, isEnable, false);
		}

		// Token: 0x060300BD RID: 196797 RVA: 0x00689731 File Offset: 0x00687931
		public static void AddFuncKey(FlatBufferBuilder builder, EEnableKey4FuncKey funcKey)
		{
			builder.AddByte(1, (byte)funcKey, 0);
		}

		// Token: 0x060300BE RID: 196798 RVA: 0x0068973C File Offset: 0x0068793C
		public static Offset<IEnableKey4Func> EndIEnableKey4Func(FlatBufferBuilder builder)
		{
			return new Offset<IEnableKey4Func>(builder.EndTable());
		}

		// Token: 0x060300BF RID: 196799 RVA: 0x0068974C File Offset: 0x0068794C
		public IEnableKey4FuncT UnPack()
		{
			IEnableKey4FuncT enableKey4FuncT = new IEnableKey4FuncT();
			this.UnPackTo(enableKey4FuncT);
			return enableKey4FuncT;
		}

		// Token: 0x060300C0 RID: 196800 RVA: 0x00689767 File Offset: 0x00687967
		public void UnPackTo(IEnableKey4FuncT _o)
		{
			_o.IsEnable = this.IsEnable;
			_o.FuncKey = this.FuncKey;
		}

		// Token: 0x060300C1 RID: 196801 RVA: 0x00689784 File Offset: 0x00687984
		public static Offset<IEnableKey4Func> Pack(FlatBufferBuilder builder, IEnableKey4FuncT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnableKey4Func>);
			}
			return IEnableKey4Func.CreateIEnableKey4Func(builder, _o.IsEnable, _o.FuncKey);
		}

		// Token: 0x04011B31 RID: 72497
		private Table __p;
	}
}
