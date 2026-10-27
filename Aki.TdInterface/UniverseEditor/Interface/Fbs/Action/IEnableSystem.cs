using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006693 RID: 26259
	public struct IEnableSystem : IFlatbufferObject
	{
		// Token: 0x1700C329 RID: 49961
		// (get) Token: 0x0602DA41 RID: 186945 RVA: 0x0063F2D0 File Offset: 0x0063D4D0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DA42 RID: 186946 RVA: 0x0063F2DD File Offset: 0x0063D4DD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DA43 RID: 186947 RVA: 0x0063F2E4 File Offset: 0x0063D4E4
		public static IEnableSystem GetRootAsIEnableSystem(ByteBuffer _bb)
		{
			return IEnableSystem.GetRootAsIEnableSystem(_bb, default(IEnableSystem));
		}

		// Token: 0x0602DA44 RID: 186948 RVA: 0x0063F300 File Offset: 0x0063D500
		public static IEnableSystem GetRootAsIEnableSystem(ByteBuffer _bb, IEnableSystem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DA45 RID: 186949 RVA: 0x0063F31D File Offset: 0x0063D51D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DA46 RID: 186950 RVA: 0x0063F32C File Offset: 0x0063D52C
		public IEnableSystem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C32A RID: 49962
		// (get) Token: 0x0602DA47 RID: 186951 RVA: 0x0063F33C File Offset: 0x0063D53C
		public ESystem SystemType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESystem.None;
				}
				return (ESystem)this.__p.bb.GetUshort(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C32B RID: 49963
		// (get) Token: 0x0602DA48 RID: 186952 RVA: 0x0063F378 File Offset: 0x0063D578
		public bool IsEnable
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602DA49 RID: 186953 RVA: 0x0063F3B7 File Offset: 0x0063D5B7
		public static Offset<IEnableSystem> CreateIEnableSystem(FlatBufferBuilder builder, ESystem SystemType = ESystem.None, bool IsEnable = false)
		{
			builder.StartTable(2);
			IEnableSystem.AddSystemType(builder, SystemType);
			IEnableSystem.AddIsEnable(builder, IsEnable);
			return IEnableSystem.EndIEnableSystem(builder);
		}

		// Token: 0x0602DA4A RID: 186954 RVA: 0x0063F3D4 File Offset: 0x0063D5D4
		public static void StartIEnableSystem(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602DA4B RID: 186955 RVA: 0x0063F3DD File Offset: 0x0063D5DD
		public static void AddSystemType(FlatBufferBuilder builder, ESystem systemType)
		{
			builder.AddUshort(0, (ushort)systemType, 0);
		}

		// Token: 0x0602DA4C RID: 186956 RVA: 0x0063F3E8 File Offset: 0x0063D5E8
		public static void AddIsEnable(FlatBufferBuilder builder, bool isEnable)
		{
			builder.AddBool(1, isEnable, false);
		}

		// Token: 0x0602DA4D RID: 186957 RVA: 0x0063F3F3 File Offset: 0x0063D5F3
		public static Offset<IEnableSystem> EndIEnableSystem(FlatBufferBuilder builder)
		{
			return new Offset<IEnableSystem>(builder.EndTable());
		}

		// Token: 0x0602DA4E RID: 186958 RVA: 0x0063F400 File Offset: 0x0063D600
		public IEnableSystemT UnPack()
		{
			IEnableSystemT enableSystemT = new IEnableSystemT();
			this.UnPackTo(enableSystemT);
			return enableSystemT;
		}

		// Token: 0x0602DA4F RID: 186959 RVA: 0x0063F41B File Offset: 0x0063D61B
		public void UnPackTo(IEnableSystemT _o)
		{
			_o.SystemType = this.SystemType;
			_o.IsEnable = this.IsEnable;
		}

		// Token: 0x0602DA50 RID: 186960 RVA: 0x0063F438 File Offset: 0x0063D638
		public static Offset<IEnableSystem> Pack(FlatBufferBuilder builder, IEnableSystemT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnableSystem>);
			}
			return IEnableSystem.CreateIEnableSystem(builder, _o.SystemType, _o.IsEnable);
		}

		// Token: 0x04010D4F RID: 68943
		private Table __p;
	}
}
