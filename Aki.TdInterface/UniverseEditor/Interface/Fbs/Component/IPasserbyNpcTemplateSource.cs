using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CD5 RID: 23765
	public struct IPasserbyNpcTemplateSource : IFlatbufferObject
	{
		// Token: 0x1700AE9F RID: 44703
		// (get) Token: 0x0602772D RID: 161581 RVA: 0x005662E8 File Offset: 0x005644E8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602772E RID: 161582 RVA: 0x005662F5 File Offset: 0x005644F5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602772F RID: 161583 RVA: 0x005662FC File Offset: 0x005644FC
		public static IPasserbyNpcTemplateSource GetRootAsIPasserbyNpcTemplateSource(ByteBuffer _bb)
		{
			return IPasserbyNpcTemplateSource.GetRootAsIPasserbyNpcTemplateSource(_bb, default(IPasserbyNpcTemplateSource));
		}

		// Token: 0x06027730 RID: 161584 RVA: 0x00566318 File Offset: 0x00564518
		public static IPasserbyNpcTemplateSource GetRootAsIPasserbyNpcTemplateSource(ByteBuffer _bb, IPasserbyNpcTemplateSource obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027731 RID: 161585 RVA: 0x00566335 File Offset: 0x00564535
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027732 RID: 161586 RVA: 0x00566344 File Offset: 0x00564544
		public IPasserbyNpcTemplateSource __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AEA0 RID: 44704
		// (get) Token: 0x06027733 RID: 161587 RVA: 0x00566354 File Offset: 0x00564554
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

		// Token: 0x06027734 RID: 161588 RVA: 0x00566390 File Offset: 0x00564590
		public string TemplateIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700AEA1 RID: 44705
		// (get) Token: 0x06027735 RID: 161589 RVA: 0x005663CC File Offset: 0x005645CC
		public int TemplateIdsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06027736 RID: 161590 RVA: 0x005663F7 File Offset: 0x005645F7
		public static Offset<IPasserbyNpcTemplateSource> CreateIPasserbyNpcTemplateSource(FlatBufferBuilder builder, EPasserbyNpcSource Type = EPasserbyNpcSource.Template, VectorOffset TemplateIdsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IPasserbyNpcTemplateSource.AddTemplateIds(builder, TemplateIdsOffset);
			IPasserbyNpcTemplateSource.AddType(builder, Type);
			return IPasserbyNpcTemplateSource.EndIPasserbyNpcTemplateSource(builder);
		}

		// Token: 0x06027737 RID: 161591 RVA: 0x00566414 File Offset: 0x00564614
		public static void StartIPasserbyNpcTemplateSource(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06027738 RID: 161592 RVA: 0x0056641D File Offset: 0x0056461D
		public static void AddType(FlatBufferBuilder builder, EPasserbyNpcSource type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06027739 RID: 161593 RVA: 0x00566428 File Offset: 0x00564628
		public static void AddTemplateIds(FlatBufferBuilder builder, VectorOffset templateIdsOffset)
		{
			builder.AddOffset(1, templateIdsOffset.Value, 0);
		}

		// Token: 0x0602773A RID: 161594 RVA: 0x00566438 File Offset: 0x00564638
		public static VectorOffset CreateTemplateIdsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602773B RID: 161595 RVA: 0x00566478 File Offset: 0x00564678
		public static VectorOffset CreateTemplateIdsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602773C RID: 161596 RVA: 0x00566492 File Offset: 0x00564692
		public static VectorOffset CreateTemplateIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602773D RID: 161597 RVA: 0x005664B0 File Offset: 0x005646B0
		public static VectorOffset CreateTemplateIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602773E RID: 161598 RVA: 0x005664C9 File Offset: 0x005646C9
		public static void StartTemplateIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602773F RID: 161599 RVA: 0x005664D4 File Offset: 0x005646D4
		public static Offset<IPasserbyNpcTemplateSource> EndIPasserbyNpcTemplateSource(FlatBufferBuilder builder)
		{
			return new Offset<IPasserbyNpcTemplateSource>(builder.EndTable());
		}

		// Token: 0x06027740 RID: 161600 RVA: 0x005664E4 File Offset: 0x005646E4
		public IPasserbyNpcTemplateSourceT UnPack()
		{
			IPasserbyNpcTemplateSourceT passerbyNpcTemplateSourceT = new IPasserbyNpcTemplateSourceT();
			this.UnPackTo(passerbyNpcTemplateSourceT);
			return passerbyNpcTemplateSourceT;
		}

		// Token: 0x06027741 RID: 161601 RVA: 0x00566500 File Offset: 0x00564700
		public void UnPackTo(IPasserbyNpcTemplateSourceT _o)
		{
			_o.Type = this.Type;
			_o.TemplateIds = new List<string>();
			for (int i = 0; i < this.TemplateIdsLength; i++)
			{
				_o.TemplateIds.Add(this.TemplateIds(i));
			}
		}

		// Token: 0x06027742 RID: 161602 RVA: 0x00566548 File Offset: 0x00564748
		public static Offset<IPasserbyNpcTemplateSource> Pack(FlatBufferBuilder builder, IPasserbyNpcTemplateSourceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPasserbyNpcTemplateSource>);
			}
			VectorOffset templateIdsOffset = default(VectorOffset);
			if (_o.TemplateIds != null)
			{
				StringOffset[] array = new StringOffset[_o.TemplateIds.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.TemplateIds[i]);
				}
				templateIdsOffset = IPasserbyNpcTemplateSource.CreateTemplateIdsVector(builder, array);
			}
			return IPasserbyNpcTemplateSource.CreateIPasserbyNpcTemplateSource(builder, _o.Type, templateIdsOffset);
		}

		// Token: 0x0400F803 RID: 63491
		private Table __p;
	}
}
