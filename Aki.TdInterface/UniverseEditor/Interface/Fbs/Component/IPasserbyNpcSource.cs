using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CB4 RID: 23732
	public struct IPasserbyNpcSource : IFlatbufferObject
	{
		// Token: 0x1700AE57 RID: 44631
		// (get) Token: 0x06027613 RID: 161299 RVA: 0x00563FB9 File Offset: 0x005621B9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027614 RID: 161300 RVA: 0x00563FC6 File Offset: 0x005621C6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027615 RID: 161301 RVA: 0x00563FD0 File Offset: 0x005621D0
		public static IPasserbyNpcSource GetRootAsIPasserbyNpcSource(ByteBuffer _bb)
		{
			return IPasserbyNpcSource.GetRootAsIPasserbyNpcSource(_bb, default(IPasserbyNpcSource));
		}

		// Token: 0x06027616 RID: 161302 RVA: 0x00563FEC File Offset: 0x005621EC
		public static IPasserbyNpcSource GetRootAsIPasserbyNpcSource(ByteBuffer _bb, IPasserbyNpcSource obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027617 RID: 161303 RVA: 0x00564009 File Offset: 0x00562209
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027618 RID: 161304 RVA: 0x00564018 File Offset: 0x00562218
		public IPasserbyNpcSource __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AE58 RID: 44632
		// (get) Token: 0x06027619 RID: 161305 RVA: 0x00564028 File Offset: 0x00562228
		public EPasserbyNpcSource Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPasserbyNpcSource.Template;
				}
				return (EPasserbyNpcSource)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602761A RID: 161306 RVA: 0x00564064 File Offset: 0x00562264
		public static Offset<IPasserbyNpcSource> CreateIPasserbyNpcSource(FlatBufferBuilder builder, EPasserbyNpcSource Type = EPasserbyNpcSource.Template)
		{
			builder.StartTable(1);
			IPasserbyNpcSource.AddType(builder, Type);
			return IPasserbyNpcSource.EndIPasserbyNpcSource(builder);
		}

		// Token: 0x0602761B RID: 161307 RVA: 0x0056407A File Offset: 0x0056227A
		public static void StartIPasserbyNpcSource(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602761C RID: 161308 RVA: 0x00564083 File Offset: 0x00562283
		public static void AddType(FlatBufferBuilder builder, EPasserbyNpcSource type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602761D RID: 161309 RVA: 0x0056408E File Offset: 0x0056228E
		public static Offset<IPasserbyNpcSource> EndIPasserbyNpcSource(FlatBufferBuilder builder)
		{
			return new Offset<IPasserbyNpcSource>(builder.EndTable());
		}

		// Token: 0x0602761E RID: 161310 RVA: 0x0056409C File Offset: 0x0056229C
		public IPasserbyNpcSourceT UnPack()
		{
			IPasserbyNpcSourceT passerbyNpcSourceT = new IPasserbyNpcSourceT();
			this.UnPackTo(passerbyNpcSourceT);
			return passerbyNpcSourceT;
		}

		// Token: 0x0602761F RID: 161311 RVA: 0x005640B7 File Offset: 0x005622B7
		public void UnPackTo(IPasserbyNpcSourceT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06027620 RID: 161312 RVA: 0x005640C8 File Offset: 0x005622C8
		public static Offset<IPasserbyNpcSource> Pack(FlatBufferBuilder builder, IPasserbyNpcSourceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPasserbyNpcSource>);
			}
			return IPasserbyNpcSource.CreateIPasserbyNpcSource(builder, _o.Type);
		}

		// Token: 0x0400F7CB RID: 63435
		private Table __p;
	}
}
