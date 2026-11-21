using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D0D RID: 27917
	public struct IEnableSystem : IFlatbufferObject
	{
		// Token: 0x1700CCDA RID: 52442
		// (get) Token: 0x0603025E RID: 197214 RVA: 0x0068C584 File Offset: 0x0068A784
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603025F RID: 197215 RVA: 0x0068C591 File Offset: 0x0068A791
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030260 RID: 197216 RVA: 0x0068C598 File Offset: 0x0068A798
		public static IEnableSystem GetRootAsIEnableSystem(ByteBuffer _bb)
		{
			return IEnableSystem.GetRootAsIEnableSystem(_bb, default(IEnableSystem));
		}

		// Token: 0x06030261 RID: 197217 RVA: 0x0068C5B4 File Offset: 0x0068A7B4
		public static IEnableSystem GetRootAsIEnableSystem(ByteBuffer _bb, IEnableSystem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030262 RID: 197218 RVA: 0x0068C5D1 File Offset: 0x0068A7D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030263 RID: 197219 RVA: 0x0068C5E0 File Offset: 0x0068A7E0
		public IEnableSystem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CCDB RID: 52443
		// (get) Token: 0x06030264 RID: 197220 RVA: 0x0068C5F0 File Offset: 0x0068A7F0
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

		// Token: 0x1700CCDC RID: 52444
		// (get) Token: 0x06030265 RID: 197221 RVA: 0x0068C62C File Offset: 0x0068A82C
		public bool IsEnable
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06030266 RID: 197222 RVA: 0x0068C66B File Offset: 0x0068A86B
		public static Offset<IEnableSystem> CreateIEnableSystem(FlatBufferBuilder builder, ESystem SystemType = ESystem.None, bool IsEnable = false)
		{
			builder.StartTable(2);
			IEnableSystem.AddSystemType(builder, SystemType);
			IEnableSystem.AddIsEnable(builder, IsEnable);
			return IEnableSystem.EndIEnableSystem(builder);
		}

		// Token: 0x06030267 RID: 197223 RVA: 0x0068C688 File Offset: 0x0068A888
		public static void StartIEnableSystem(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06030268 RID: 197224 RVA: 0x0068C691 File Offset: 0x0068A891
		public static void AddSystemType(FlatBufferBuilder builder, ESystem systemType)
		{
			builder.AddUshort(0, (ushort)systemType, 0);
		}

		// Token: 0x06030269 RID: 197225 RVA: 0x0068C69C File Offset: 0x0068A89C
		public static void AddIsEnable(FlatBufferBuilder builder, bool isEnable)
		{
			builder.AddBool(1, isEnable, false);
		}

		// Token: 0x0603026A RID: 197226 RVA: 0x0068C6A7 File Offset: 0x0068A8A7
		public static Offset<IEnableSystem> EndIEnableSystem(FlatBufferBuilder builder)
		{
			return new Offset<IEnableSystem>(builder.EndTable());
		}

		// Token: 0x0603026B RID: 197227 RVA: 0x0068C6B4 File Offset: 0x0068A8B4
		public IEnableSystemT UnPack()
		{
			IEnableSystemT enableSystemT = new IEnableSystemT();
			this.UnPackTo(enableSystemT);
			return enableSystemT;
		}

		// Token: 0x0603026C RID: 197228 RVA: 0x0068C6CF File Offset: 0x0068A8CF
		public void UnPackTo(IEnableSystemT _o)
		{
			_o.SystemType = this.SystemType;
			_o.IsEnable = this.IsEnable;
		}

		// Token: 0x0603026D RID: 197229 RVA: 0x0068C6EC File Offset: 0x0068A8EC
		public static Offset<IEnableSystem> Pack(FlatBufferBuilder builder, IEnableSystemT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnableSystem>);
			}
			return IEnableSystem.CreateIEnableSystem(builder, _o.SystemType, _o.IsEnable);
		}

		// Token: 0x04011B75 RID: 72565
		private Table __p;
	}
}
