using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056E6 RID: 22246
	public struct IPasserbyNpcTemplateSource : IFlatbufferObject
	{
		// Token: 0x1700A59C RID: 42396
		// (get) Token: 0x060252C6 RID: 152262 RVA: 0x0052189C File Offset: 0x0051FA9C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060252C7 RID: 152263 RVA: 0x005218A9 File Offset: 0x0051FAA9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060252C8 RID: 152264 RVA: 0x005218B0 File Offset: 0x0051FAB0
		public static IPasserbyNpcTemplateSource GetRootAsIPasserbyNpcTemplateSource(ByteBuffer _bb)
		{
			return IPasserbyNpcTemplateSource.GetRootAsIPasserbyNpcTemplateSource(_bb, default(IPasserbyNpcTemplateSource));
		}

		// Token: 0x060252C9 RID: 152265 RVA: 0x005218CC File Offset: 0x0051FACC
		public static IPasserbyNpcTemplateSource GetRootAsIPasserbyNpcTemplateSource(ByteBuffer _bb, IPasserbyNpcTemplateSource obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060252CA RID: 152266 RVA: 0x005218E9 File Offset: 0x0051FAE9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060252CB RID: 152267 RVA: 0x005218F8 File Offset: 0x0051FAF8
		public IPasserbyNpcTemplateSource __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A59D RID: 42397
		// (get) Token: 0x060252CC RID: 152268 RVA: 0x00521908 File Offset: 0x0051FB08
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

		// Token: 0x060252CD RID: 152269 RVA: 0x00521944 File Offset: 0x0051FB44
		public string TemplateIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700A59E RID: 42398
		// (get) Token: 0x060252CE RID: 152270 RVA: 0x00521980 File Offset: 0x0051FB80
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

		// Token: 0x060252CF RID: 152271 RVA: 0x005219AB File Offset: 0x0051FBAB
		public static Offset<IPasserbyNpcTemplateSource> CreateIPasserbyNpcTemplateSource(FlatBufferBuilder builder, EPasserbyNpcSource Type = EPasserbyNpcSource.Template, VectorOffset TemplateIdsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IPasserbyNpcTemplateSource.AddTemplateIds(builder, TemplateIdsOffset);
			IPasserbyNpcTemplateSource.AddType(builder, Type);
			return IPasserbyNpcTemplateSource.EndIPasserbyNpcTemplateSource(builder);
		}

		// Token: 0x060252D0 RID: 152272 RVA: 0x005219C8 File Offset: 0x0051FBC8
		public static void StartIPasserbyNpcTemplateSource(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060252D1 RID: 152273 RVA: 0x005219D1 File Offset: 0x0051FBD1
		public static void AddType(FlatBufferBuilder builder, EPasserbyNpcSource type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060252D2 RID: 152274 RVA: 0x005219DC File Offset: 0x0051FBDC
		public static void AddTemplateIds(FlatBufferBuilder builder, VectorOffset templateIdsOffset)
		{
			builder.AddOffset(1, templateIdsOffset.Value, 0);
		}

		// Token: 0x060252D3 RID: 152275 RVA: 0x005219EC File Offset: 0x0051FBEC
		public static VectorOffset CreateTemplateIdsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060252D4 RID: 152276 RVA: 0x00521A2C File Offset: 0x0051FC2C
		public static VectorOffset CreateTemplateIdsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x060252D5 RID: 152277 RVA: 0x00521A46 File Offset: 0x0051FC46
		public static VectorOffset CreateTemplateIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x060252D6 RID: 152278 RVA: 0x00521A64 File Offset: 0x0051FC64
		public static VectorOffset CreateTemplateIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060252D7 RID: 152279 RVA: 0x00521A7D File Offset: 0x0051FC7D
		public static void StartTemplateIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060252D8 RID: 152280 RVA: 0x00521A88 File Offset: 0x0051FC88
		public static Offset<IPasserbyNpcTemplateSource> EndIPasserbyNpcTemplateSource(FlatBufferBuilder builder)
		{
			return new Offset<IPasserbyNpcTemplateSource>(builder.EndTable());
		}

		// Token: 0x060252D9 RID: 152281 RVA: 0x00521A98 File Offset: 0x0051FC98
		public IPasserbyNpcTemplateSourceT UnPack()
		{
			IPasserbyNpcTemplateSourceT passerbyNpcTemplateSourceT = new IPasserbyNpcTemplateSourceT();
			this.UnPackTo(passerbyNpcTemplateSourceT);
			return passerbyNpcTemplateSourceT;
		}

		// Token: 0x060252DA RID: 152282 RVA: 0x00521AB4 File Offset: 0x0051FCB4
		public void UnPackTo(IPasserbyNpcTemplateSourceT _o)
		{
			_o.Type = this.Type;
			_o.TemplateIds = new List<string>();
			for (int i = 0; i < this.TemplateIdsLength; i++)
			{
				_o.TemplateIds.Add(this.TemplateIds(i));
			}
		}

		// Token: 0x060252DB RID: 152283 RVA: 0x00521AFC File Offset: 0x0051FCFC
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

		// Token: 0x0400EB36 RID: 60214
		private Table __p;
	}
}
