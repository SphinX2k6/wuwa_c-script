using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A9C RID: 23196
	public struct ITimeScheduleEntityTemplateNpcSource : IFlatbufferObject
	{
		// Token: 0x1700AEBB RID: 44731
		// (get) Token: 0x06027852 RID: 161874 RVA: 0x0056FE9E File Offset: 0x0056E09E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027853 RID: 161875 RVA: 0x0056FEAB File Offset: 0x0056E0AB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027854 RID: 161876 RVA: 0x0056FEB4 File Offset: 0x0056E0B4
		public static ITimeScheduleEntityTemplateNpcSource GetRootAsITimeScheduleEntityTemplateNpcSource(ByteBuffer _bb)
		{
			return ITimeScheduleEntityTemplateNpcSource.GetRootAsITimeScheduleEntityTemplateNpcSource(_bb, default(ITimeScheduleEntityTemplateNpcSource));
		}

		// Token: 0x06027855 RID: 161877 RVA: 0x0056FED0 File Offset: 0x0056E0D0
		public static ITimeScheduleEntityTemplateNpcSource GetRootAsITimeScheduleEntityTemplateNpcSource(ByteBuffer _bb, ITimeScheduleEntityTemplateNpcSource obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027856 RID: 161878 RVA: 0x0056FEED File Offset: 0x0056E0ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027857 RID: 161879 RVA: 0x0056FEFC File Offset: 0x0056E0FC
		public ITimeScheduleEntityTemplateNpcSource __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AEBC RID: 44732
		// (get) Token: 0x06027858 RID: 161880 RVA: 0x0056FF0C File Offset: 0x0056E10C
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

		// Token: 0x06027859 RID: 161881 RVA: 0x0056FF48 File Offset: 0x0056E148
		public string TemplateIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700AEBD RID: 44733
		// (get) Token: 0x0602785A RID: 161882 RVA: 0x0056FF84 File Offset: 0x0056E184
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

		// Token: 0x0602785B RID: 161883 RVA: 0x0056FFAF File Offset: 0x0056E1AF
		public static Offset<ITimeScheduleEntityTemplateNpcSource> CreateITimeScheduleEntityTemplateNpcSource(FlatBufferBuilder builder, ETimeScheduleNpcSourceType Type = ETimeScheduleNpcSourceType.EntityTemplate, VectorOffset TemplateIdsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ITimeScheduleEntityTemplateNpcSource.AddTemplateIds(builder, TemplateIdsOffset);
			ITimeScheduleEntityTemplateNpcSource.AddType(builder, Type);
			return ITimeScheduleEntityTemplateNpcSource.EndITimeScheduleEntityTemplateNpcSource(builder);
		}

		// Token: 0x0602785C RID: 161884 RVA: 0x0056FFCC File Offset: 0x0056E1CC
		public static void StartITimeScheduleEntityTemplateNpcSource(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602785D RID: 161885 RVA: 0x0056FFD5 File Offset: 0x0056E1D5
		public static void AddType(FlatBufferBuilder builder, ETimeScheduleNpcSourceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602785E RID: 161886 RVA: 0x0056FFE0 File Offset: 0x0056E1E0
		public static void AddTemplateIds(FlatBufferBuilder builder, VectorOffset templateIdsOffset)
		{
			builder.AddOffset(1, templateIdsOffset.Value, 0);
		}

		// Token: 0x0602785F RID: 161887 RVA: 0x0056FFF0 File Offset: 0x0056E1F0
		public static VectorOffset CreateTemplateIdsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06027860 RID: 161888 RVA: 0x00570030 File Offset: 0x0056E230
		public static VectorOffset CreateTemplateIdsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06027861 RID: 161889 RVA: 0x0057004A File Offset: 0x0056E24A
		public static VectorOffset CreateTemplateIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06027862 RID: 161890 RVA: 0x00570068 File Offset: 0x0056E268
		public static VectorOffset CreateTemplateIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06027863 RID: 161891 RVA: 0x00570081 File Offset: 0x0056E281
		public static void StartTemplateIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06027864 RID: 161892 RVA: 0x0057008C File Offset: 0x0056E28C
		public static Offset<ITimeScheduleEntityTemplateNpcSource> EndITimeScheduleEntityTemplateNpcSource(FlatBufferBuilder builder)
		{
			return new Offset<ITimeScheduleEntityTemplateNpcSource>(builder.EndTable());
		}

		// Token: 0x06027865 RID: 161893 RVA: 0x0057009C File Offset: 0x0056E29C
		public ITimeScheduleEntityTemplateNpcSourceT UnPack()
		{
			ITimeScheduleEntityTemplateNpcSourceT timeScheduleEntityTemplateNpcSourceT = new ITimeScheduleEntityTemplateNpcSourceT();
			this.UnPackTo(timeScheduleEntityTemplateNpcSourceT);
			return timeScheduleEntityTemplateNpcSourceT;
		}

		// Token: 0x06027866 RID: 161894 RVA: 0x005700B8 File Offset: 0x0056E2B8
		public void UnPackTo(ITimeScheduleEntityTemplateNpcSourceT _o)
		{
			_o.Type = this.Type;
			_o.TemplateIds = new List<string>();
			for (int i = 0; i < this.TemplateIdsLength; i++)
			{
				_o.TemplateIds.Add(this.TemplateIds(i));
			}
		}

		// Token: 0x06027867 RID: 161895 RVA: 0x00570100 File Offset: 0x0056E300
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

		// Token: 0x0400F15D RID: 61789
		private Table __p;
	}
}
