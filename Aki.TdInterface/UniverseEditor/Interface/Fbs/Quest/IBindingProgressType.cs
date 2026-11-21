using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004148 RID: 16712
	public struct IBindingProgressType : IFlatbufferObject
	{
		// Token: 0x17007130 RID: 28976
		// (get) Token: 0x06016F61 RID: 94049 RVA: 0x00346AAE File Offset: 0x00344CAE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016F62 RID: 94050 RVA: 0x00346ABB File Offset: 0x00344CBB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016F63 RID: 94051 RVA: 0x00346AC4 File Offset: 0x00344CC4
		public static IBindingProgressType GetRootAsIBindingProgressType(ByteBuffer _bb)
		{
			return IBindingProgressType.GetRootAsIBindingProgressType(_bb, default(IBindingProgressType));
		}

		// Token: 0x06016F64 RID: 94052 RVA: 0x00346AE0 File Offset: 0x00344CE0
		public static IBindingProgressType GetRootAsIBindingProgressType(ByteBuffer _bb, IBindingProgressType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016F65 RID: 94053 RVA: 0x00346AFD File Offset: 0x00344CFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016F66 RID: 94054 RVA: 0x00346B0C File Offset: 0x00344D0C
		public IBindingProgressType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007131 RID: 28977
		// (get) Token: 0x06016F67 RID: 94055 RVA: 0x00346B1C File Offset: 0x00344D1C
		public EBindingProgressType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBindingProgressType.PlayerHavingItemCount;
				}
				return (EBindingProgressType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06016F68 RID: 94056 RVA: 0x00346B58 File Offset: 0x00344D58
		public static Offset<IBindingProgressType> CreateIBindingProgressType(FlatBufferBuilder builder, EBindingProgressType Type = EBindingProgressType.PlayerHavingItemCount)
		{
			builder.StartTable(1);
			IBindingProgressType.AddType(builder, Type);
			return IBindingProgressType.EndIBindingProgressType(builder);
		}

		// Token: 0x06016F69 RID: 94057 RVA: 0x00346B6E File Offset: 0x00344D6E
		public static void StartIBindingProgressType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06016F6A RID: 94058 RVA: 0x00346B77 File Offset: 0x00344D77
		public static void AddType(FlatBufferBuilder builder, EBindingProgressType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016F6B RID: 94059 RVA: 0x00346B82 File Offset: 0x00344D82
		public static Offset<IBindingProgressType> EndIBindingProgressType(FlatBufferBuilder builder)
		{
			return new Offset<IBindingProgressType>(builder.EndTable());
		}

		// Token: 0x06016F6C RID: 94060 RVA: 0x00346B90 File Offset: 0x00344D90
		public IBindingProgressTypeT UnPack()
		{
			IBindingProgressTypeT bindingProgressTypeT = new IBindingProgressTypeT();
			this.UnPackTo(bindingProgressTypeT);
			return bindingProgressTypeT;
		}

		// Token: 0x06016F6D RID: 94061 RVA: 0x00346BAB File Offset: 0x00344DAB
		public void UnPackTo(IBindingProgressTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06016F6E RID: 94062 RVA: 0x00346BBC File Offset: 0x00344DBC
		public static Offset<IBindingProgressType> Pack(FlatBufferBuilder builder, IBindingProgressTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBindingProgressType>);
			}
			return IBindingProgressType.CreateIBindingProgressType(builder, _o.Type);
		}

		// Token: 0x0400BF9C RID: 49052
		private Table __p;
	}
}
