using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060A3 RID: 24739
	public struct ITimeScheduleEntityTemplateNpcSource : IFlatbufferObject
	{
		// Token: 0x1700B7EE RID: 47086
		// (get) Token: 0x06029DAC RID: 171436 RVA: 0x005B6C38 File Offset: 0x005B4E38
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029DAD RID: 171437 RVA: 0x005B6C45 File Offset: 0x005B4E45
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029DAE RID: 171438 RVA: 0x005B6C4C File Offset: 0x005B4E4C
		public static ITimeScheduleEntityTemplateNpcSource GetRootAsITimeScheduleEntityTemplateNpcSource(ByteBuffer _bb)
		{
			return ITimeScheduleEntityTemplateNpcSource.GetRootAsITimeScheduleEntityTemplateNpcSource(_bb, default(ITimeScheduleEntityTemplateNpcSource));
		}

		// Token: 0x06029DAF RID: 171439 RVA: 0x005B6C68 File Offset: 0x005B4E68
		public static ITimeScheduleEntityTemplateNpcSource GetRootAsITimeScheduleEntityTemplateNpcSource(ByteBuffer _bb, ITimeScheduleEntityTemplateNpcSource obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029DB0 RID: 171440 RVA: 0x005B6C85 File Offset: 0x005B4E85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029DB1 RID: 171441 RVA: 0x005B6C94 File Offset: 0x005B4E94
		public ITimeScheduleEntityTemplateNpcSource __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B7EF RID: 47087
		// (get) Token: 0x06029DB2 RID: 171442 RVA: 0x005B6CA4 File Offset: 0x005B4EA4
		public ETimeScheduleNpcSourceType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETimeScheduleNpcSourceType.EntityTemplate;
				}
				return (ETimeScheduleNpcSourceType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029DB3 RID: 171443 RVA: 0x005B6CE0 File Offset: 0x005B4EE0
		public string TemplateIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700B7F0 RID: 47088
		// (get) Token: 0x06029DB4 RID: 171444 RVA: 0x005B6D1C File Offset: 0x005B4F1C
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

		// Token: 0x06029DB5 RID: 171445 RVA: 0x005B6D47 File Offset: 0x005B4F47
		public static Offset<ITimeScheduleEntityTemplateNpcSource> CreateITimeScheduleEntityTemplateNpcSource(FlatBufferBuilder builder, ETimeScheduleNpcSourceType Type = ETimeScheduleNpcSourceType.EntityTemplate, VectorOffset TemplateIdsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ITimeScheduleEntityTemplateNpcSource.AddTemplateIds(builder, TemplateIdsOffset);
			ITimeScheduleEntityTemplateNpcSource.AddType(builder, Type);
			return ITimeScheduleEntityTemplateNpcSource.EndITimeScheduleEntityTemplateNpcSource(builder);
		}

		// Token: 0x06029DB6 RID: 171446 RVA: 0x005B6D64 File Offset: 0x005B4F64
		public static void StartITimeScheduleEntityTemplateNpcSource(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06029DB7 RID: 171447 RVA: 0x005B6D6D File Offset: 0x005B4F6D
		public static void AddType(FlatBufferBuilder builder, ETimeScheduleNpcSourceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06029DB8 RID: 171448 RVA: 0x005B6D78 File Offset: 0x005B4F78
		public static void AddTemplateIds(FlatBufferBuilder builder, VectorOffset templateIdsOffset)
		{
			builder.AddOffset(1, templateIdsOffset.Value, 0);
		}

		// Token: 0x06029DB9 RID: 171449 RVA: 0x005B6D88 File Offset: 0x005B4F88
		public static VectorOffset CreateTemplateIdsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06029DBA RID: 171450 RVA: 0x005B6DC8 File Offset: 0x005B4FC8
		public static VectorOffset CreateTemplateIdsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06029DBB RID: 171451 RVA: 0x005B6DE2 File Offset: 0x005B4FE2
		public static VectorOffset CreateTemplateIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06029DBC RID: 171452 RVA: 0x005B6E00 File Offset: 0x005B5000
		public static VectorOffset CreateTemplateIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06029DBD RID: 171453 RVA: 0x005B6E19 File Offset: 0x005B5019
		public static void StartTemplateIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06029DBE RID: 171454 RVA: 0x005B6E24 File Offset: 0x005B5024
		public static Offset<ITimeScheduleEntityTemplateNpcSource> EndITimeScheduleEntityTemplateNpcSource(FlatBufferBuilder builder)
		{
			return new Offset<ITimeScheduleEntityTemplateNpcSource>(builder.EndTable());
		}

		// Token: 0x06029DBF RID: 171455 RVA: 0x005B6E34 File Offset: 0x005B5034
		public ITimeScheduleEntityTemplateNpcSourceT UnPack()
		{
			ITimeScheduleEntityTemplateNpcSourceT timeScheduleEntityTemplateNpcSourceT = new ITimeScheduleEntityTemplateNpcSourceT();
			this.UnPackTo(timeScheduleEntityTemplateNpcSourceT);
			return timeScheduleEntityTemplateNpcSourceT;
		}

		// Token: 0x06029DC0 RID: 171456 RVA: 0x005B6E50 File Offset: 0x005B5050
		public void UnPackTo(ITimeScheduleEntityTemplateNpcSourceT _o)
		{
			_o.Type = this.Type;
			_o.TemplateIds = new List<string>();
			for (int i = 0; i < this.TemplateIdsLength; i++)
			{
				_o.TemplateIds.Add(this.TemplateIds(i));
			}
		}

		// Token: 0x06029DC1 RID: 171457 RVA: 0x005B6E98 File Offset: 0x005B5098
		public static Offset<ITimeScheduleEntityTemplateNpcSource> Pack(FlatBufferBuilder builder, ITimeScheduleEntityTemplateNpcSourceT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITimeScheduleEntityTemplateNpcSource>);
			}
			VectorOffset templateIdsOffset = default(VectorOffset);
			if (_o.TemplateIds != null)
			{
				StringOffset[] array = new StringOffset[_o.TemplateIds.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.TemplateIds[i]);
				}
				templateIdsOffset = ITimeScheduleEntityTemplateNpcSource.CreateTemplateIdsVector(builder, array);
			}
			return ITimeScheduleEntityTemplateNpcSource.CreateITimeScheduleEntityTemplateNpcSource(builder, _o.Type, templateIdsOffset);
		}

		// Token: 0x0400FE4C RID: 65100
		private Table __p;
	}
}
