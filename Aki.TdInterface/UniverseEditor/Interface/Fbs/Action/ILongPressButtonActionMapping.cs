using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A38 RID: 27192
	public struct ILongPressButtonActionMapping : IFlatbufferObject
	{
		// Token: 0x1700C9AE RID: 51630
		// (get) Token: 0x0602F96A RID: 194922 RVA: 0x0067A2B8 File Offset: 0x006784B8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F96B RID: 194923 RVA: 0x0067A2C5 File Offset: 0x006784C5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F96C RID: 194924 RVA: 0x0067A2CC File Offset: 0x006784CC
		public static ILongPressButtonActionMapping GetRootAsILongPressButtonActionMapping(ByteBuffer _bb)
		{
			return ILongPressButtonActionMapping.GetRootAsILongPressButtonActionMapping(_bb, default(ILongPressButtonActionMapping));
		}

		// Token: 0x0602F96D RID: 194925 RVA: 0x0067A2E8 File Offset: 0x006784E8
		public static ILongPressButtonActionMapping GetRootAsILongPressButtonActionMapping(ByteBuffer _bb, ILongPressButtonActionMapping obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F96E RID: 194926 RVA: 0x0067A305 File Offset: 0x00678505
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F96F RID: 194927 RVA: 0x0067A314 File Offset: 0x00678514
		public ILongPressButtonActionMapping __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C9AF RID: 51631
		// (get) Token: 0x0602F970 RID: 194928 RVA: 0x0067A324 File Offset: 0x00678524
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C9B0 RID: 51632
		// (get) Token: 0x0602F971 RID: 194929 RVA: 0x0067A360 File Offset: 0x00678560
		public string ActionName
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F972 RID: 194930 RVA: 0x0067A397 File Offset: 0x00678597
		public Span<byte> GetActionNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602F973 RID: 194931 RVA: 0x0067A3A6 File Offset: 0x006785A6
		public byte[] GetActionNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602F974 RID: 194932 RVA: 0x0067A3B4 File Offset: 0x006785B4
		public static Offset<ILongPressButtonActionMapping> CreateILongPressButtonActionMapping(FlatBufferBuilder builder, int Id = 0, StringOffset ActionNameOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ILongPressButtonActionMapping.AddActionName(builder, ActionNameOffset);
			ILongPressButtonActionMapping.AddId(builder, Id);
			return ILongPressButtonActionMapping.EndILongPressButtonActionMapping(builder);
		}

		// Token: 0x0602F975 RID: 194933 RVA: 0x0067A3D1 File Offset: 0x006785D1
		public static void StartILongPressButtonActionMapping(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602F976 RID: 194934 RVA: 0x0067A3DA File Offset: 0x006785DA
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0602F977 RID: 194935 RVA: 0x0067A3E5 File Offset: 0x006785E5
		public static void AddActionName(FlatBufferBuilder builder, StringOffset actionNameOffset)
		{
			builder.AddOffset(1, actionNameOffset.Value, 0);
		}

		// Token: 0x0602F978 RID: 194936 RVA: 0x0067A3F5 File Offset: 0x006785F5
		public static Offset<ILongPressButtonActionMapping> EndILongPressButtonActionMapping(FlatBufferBuilder builder)
		{
			return new Offset<ILongPressButtonActionMapping>(builder.EndTable());
		}

		// Token: 0x0602F979 RID: 194937 RVA: 0x0067A404 File Offset: 0x00678604
		public ILongPressButtonActionMappingT UnPack()
		{
			ILongPressButtonActionMappingT longPressButtonActionMappingT = new ILongPressButtonActionMappingT();
			this.UnPackTo(longPressButtonActionMappingT);
			return longPressButtonActionMappingT;
		}

		// Token: 0x0602F97A RID: 194938 RVA: 0x0067A41F File Offset: 0x0067861F
		public void UnPackTo(ILongPressButtonActionMappingT _o)
		{
			_o.Id = this.Id;
			_o.ActionName = this.ActionName;
		}

		// Token: 0x0602F97B RID: 194939 RVA: 0x0067A43C File Offset: 0x0067863C
		public static Offset<ILongPressButtonActionMapping> Pack(FlatBufferBuilder builder, ILongPressButtonActionMappingT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILongPressButtonActionMapping>);
			}
			StringOffset actionNameOffset = (_o.ActionName == null) ? default(StringOffset) : builder.CreateString(_o.ActionName);
			return ILongPressButtonActionMapping.CreateILongPressButtonActionMapping(builder, _o.Id, actionNameOffset);
		}

		// Token: 0x04011247 RID: 70215
		private Table __p;
	}
}
