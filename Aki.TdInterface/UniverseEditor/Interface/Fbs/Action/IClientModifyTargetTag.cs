using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A59 RID: 27225
	public struct IClientModifyTargetTag : IFlatbufferObject
	{
		// Token: 0x1700C802 RID: 51202
		// (get) Token: 0x0602EB3D RID: 191293 RVA: 0x0065D9A9 File Offset: 0x0065BBA9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EB3E RID: 191294 RVA: 0x0065D9B6 File Offset: 0x0065BBB6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EB3F RID: 191295 RVA: 0x0065D9C0 File Offset: 0x0065BBC0
		public static IClientModifyTargetTag GetRootAsIClientModifyTargetTag(ByteBuffer _bb)
		{
			return IClientModifyTargetTag.GetRootAsIClientModifyTargetTag(_bb, default(IClientModifyTargetTag));
		}

		// Token: 0x0602EB40 RID: 191296 RVA: 0x0065D9DC File Offset: 0x0065BBDC
		public static IClientModifyTargetTag GetRootAsIClientModifyTargetTag(ByteBuffer _bb, IClientModifyTargetTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EB41 RID: 191297 RVA: 0x0065D9F9 File Offset: 0x0065BBF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EB42 RID: 191298 RVA: 0x0065DA08 File Offset: 0x0065BC08
		public IClientModifyTargetTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C803 RID: 51203
		// (get) Token: 0x0602EB43 RID: 191299 RVA: 0x0065DA18 File Offset: 0x0065BC18
		public bool IsAddTag
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C804 RID: 51204
		// (get) Token: 0x0602EB44 RID: 191300 RVA: 0x0065DA58 File Offset: 0x0065BC58
		public TClientModifyTarget TargetType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TClientModifyTarget.NONE;
				}
				return (TClientModifyTarget)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602EB45 RID: 191301 RVA: 0x0065DA94 File Offset: 0x0065BC94
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602EB46 RID: 191302 RVA: 0x0065DAD8 File Offset: 0x0065BCD8
		public IClientModifyPlayerTarget TargetAsIClientModifyPlayerTarget()
		{
			return this.Target<IClientModifyPlayerTarget>().Value;
		}

		// Token: 0x0602EB47 RID: 191303 RVA: 0x0065DAF4 File Offset: 0x0065BCF4
		public IClientModifySelfTarget TargetAsIClientModifySelfTarget()
		{
			return this.Target<IClientModifySelfTarget>().Value;
		}

		// Token: 0x0602EB48 RID: 191304 RVA: 0x0065DB10 File Offset: 0x0065BD10
		public string PerformanceTag(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C805 RID: 51205
		// (get) Token: 0x0602EB49 RID: 191305 RVA: 0x0065DB4C File Offset: 0x0065BD4C
		public int PerformanceTagLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602EB4A RID: 191306 RVA: 0x0065DB78 File Offset: 0x0065BD78
		public static Offset<IClientModifyTargetTag> CreateIClientModifyTargetTag(FlatBufferBuilder builder, bool IsAddTag = false, TClientModifyTarget Target_type = TClientModifyTarget.NONE, int TargetOffset = 0, VectorOffset PerformanceTagOffset = default(VectorOffset))
		{
			builder.StartTable(4);
			IClientModifyTargetTag.AddPerformanceTag(builder, PerformanceTagOffset);
			IClientModifyTargetTag.AddTarget(builder, TargetOffset);
			IClientModifyTargetTag.AddTargetType(builder, Target_type);
			IClientModifyTargetTag.AddIsAddTag(builder, IsAddTag);
			return IClientModifyTargetTag.EndIClientModifyTargetTag(builder);
		}

		// Token: 0x0602EB4B RID: 191307 RVA: 0x0065DBA4 File Offset: 0x0065BDA4
		public static void StartIClientModifyTargetTag(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602EB4C RID: 191308 RVA: 0x0065DBAD File Offset: 0x0065BDAD
		public static void AddIsAddTag(FlatBufferBuilder builder, bool isAddTag)
		{
			builder.AddBool(0, isAddTag, false);
		}

		// Token: 0x0602EB4D RID: 191309 RVA: 0x0065DBB8 File Offset: 0x0065BDB8
		public static void AddTargetType(FlatBufferBuilder builder, TClientModifyTarget targetType)
		{
			builder.AddByte(1, (byte)targetType, 0);
		}

		// Token: 0x0602EB4E RID: 191310 RVA: 0x0065DBC3 File Offset: 0x0065BDC3
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(2, targetOffset, 0);
		}

		// Token: 0x0602EB4F RID: 191311 RVA: 0x0065DBCE File Offset: 0x0065BDCE
		public static void AddPerformanceTag(FlatBufferBuilder builder, VectorOffset performanceTagOffset)
		{
			builder.AddOffset(3, performanceTagOffset.Value, 0);
		}

		// Token: 0x0602EB50 RID: 191312 RVA: 0x0065DBE0 File Offset: 0x0065BDE0
		public static VectorOffset CreatePerformanceTagVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602EB51 RID: 191313 RVA: 0x0065DC20 File Offset: 0x0065BE20
		public static VectorOffset CreatePerformanceTagVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602EB52 RID: 191314 RVA: 0x0065DC3A File Offset: 0x0065BE3A
		public static VectorOffset CreatePerformanceTagVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602EB53 RID: 191315 RVA: 0x0065DC58 File Offset: 0x0065BE58
		public static VectorOffset CreatePerformanceTagVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602EB54 RID: 191316 RVA: 0x0065DC71 File Offset: 0x0065BE71
		public static void StartPerformanceTagVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602EB55 RID: 191317 RVA: 0x0065DC7C File Offset: 0x0065BE7C
		public static Offset<IClientModifyTargetTag> EndIClientModifyTargetTag(FlatBufferBuilder builder)
		{
			return new Offset<IClientModifyTargetTag>(builder.EndTable());
		}

		// Token: 0x0602EB56 RID: 191318 RVA: 0x0065DC8C File Offset: 0x0065BE8C
		public IClientModifyTargetTagT UnPack()
		{
			IClientModifyTargetTagT clientModifyTargetTagT = new IClientModifyTargetTagT();
			this.UnPackTo(clientModifyTargetTagT);
			return clientModifyTargetTagT;
		}

		// Token: 0x0602EB57 RID: 191319 RVA: 0x0065DCA8 File Offset: 0x0065BEA8
		public void UnPackTo(IClientModifyTargetTagT _o)
		{
			_o.IsAddTag = this.IsAddTag;
			_o.Target = new TClientModifyTargetUnion();
			_o.Target.Type = this.TargetType;
			TClientModifyTarget targetType = this.TargetType;
			if (targetType != TClientModifyTarget.IClientModifyPlayerTarget)
			{
				if (targetType == TClientModifyTarget.IClientModifySelfTarget)
				{
					_o.Target.Value = ((this.Target<IClientModifySelfTarget>() != null) ? this.Target<IClientModifySelfTarget>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.Target.Value = ((this.Target<IClientModifyPlayerTarget>() != null) ? this.Target<IClientModifyPlayerTarget>().Value.UnPack() : null);
			}
			_o.PerformanceTag = new List<string>();
			for (int i = 0; i < this.PerformanceTagLength; i++)
			{
				_o.PerformanceTag.Add(this.PerformanceTag(i));
			}
		}

		// Token: 0x0602EB58 RID: 191320 RVA: 0x0065DD8C File Offset: 0x0065BF8C
		public static Offset<IClientModifyTargetTag> Pack(FlatBufferBuilder builder, IClientModifyTargetTagT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClientModifyTargetTag>);
			}
			TClientModifyTarget target_type = (_o.Target == null) ? TClientModifyTarget.NONE : _o.Target.Type;
			int targetOffset = (_o.Target == null) ? 0 : TClientModifyTargetUnion.Pack(builder, _o.Target);
			VectorOffset performanceTagOffset = default(VectorOffset);
			if (_o.PerformanceTag != null)
			{
				StringOffset[] array = new StringOffset[_o.PerformanceTag.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.PerformanceTag[i]);
				}
				performanceTagOffset = IClientModifyTargetTag.CreatePerformanceTagVector(builder, array);
			}
			return IClientModifyTargetTag.CreateIClientModifyTargetTag(builder, _o.IsAddTag, target_type, targetOffset, performanceTagOffset);
		}

		// Token: 0x040117D9 RID: 71641
		private Table __p;
	}
}
