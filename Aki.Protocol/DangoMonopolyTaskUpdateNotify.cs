using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000394 RID: 916
	[NetMessage(EMessageId.DangoMonopolyTaskUpdateNotify)]
	public sealed class DangoMonopolyTaskUpdateNotify : IMessage<DangoMonopolyTaskUpdateNotify>, IMessage, IEquatable<DangoMonopolyTaskUpdateNotify>, IDeepCloneable<DangoMonopolyTaskUpdateNotify>, IBufferMessage
	{
		// Token: 0x06005A69 RID: 23145 RVA: 0x000DBFB9 File Offset: 0x000DA1B9
		[NullableContext(1)]
		public static DangoMonopolyTaskUpdateNotify Create()
		{
			return new DangoMonopolyTaskUpdateNotify();
		}

		// Token: 0x170010B5 RID: 4277
		// (get) Token: 0x06005A6A RID: 23146 RVA: 0x000DBFC0 File Offset: 0x000DA1C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170010B6 RID: 4278
		// (get) Token: 0x06005A6B RID: 23147 RVA: 0x000DBFC3 File Offset: 0x000DA1C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoMonopolyTaskUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06005A6C RID: 23148 RVA: 0x000DBFCA File Offset: 0x000DA1CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyTaskUpdateNotify()
		{
		}

		// Token: 0x06005A6D RID: 23149 RVA: 0x000DBFDD File Offset: 0x000DA1DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyTaskUpdateNotify(DangoMonopolyTaskUpdateNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.taskDatas_ = other.taskDatas_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005A6E RID: 23150 RVA: 0x000DC013 File Offset: 0x000DA213
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyTaskUpdateNotify Clone()
		{
			return new DangoMonopolyTaskUpdateNotify(this);
		}

		// Token: 0x170010B7 RID: 4279
		// (get) Token: 0x06005A6F RID: 23151 RVA: 0x000DC01B File Offset: 0x000DA21B
		// (set) Token: 0x06005A70 RID: 23152 RVA: 0x000DC023 File Offset: 0x000DA223
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x170010B8 RID: 4280
		// (get) Token: 0x06005A71 RID: 23153 RVA: 0x000DC02C File Offset: 0x000DA22C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DangoMonopolyTaskData> TaskDatas
		{
			get
			{
				return this.taskDatas_;
			}
		}

		// Token: 0x06005A72 RID: 23154 RVA: 0x000DC034 File Offset: 0x000DA234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoMonopolyTaskUpdateNotify);
		}

		// Token: 0x06005A73 RID: 23155 RVA: 0x000DC044 File Offset: 0x000DA244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoMonopolyTaskUpdateNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.taskDatas_.Equals(other.taskDatas_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005A74 RID: 23156 RVA: 0x000DC094 File Offset: 0x000DA294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.taskDatas_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005A75 RID: 23157 RVA: 0x000DC0E1 File Offset: 0x000DA2E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005A76 RID: 23158 RVA: 0x000DC0EE File Offset: 0x000DA2EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005A77 RID: 23159 RVA: 0x000DC0F8 File Offset: 0x000DA2F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.taskDatas_.WriteTo(ref output, DangoMonopolyTaskUpdateNotify._repeated_taskDatas_codec);
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005A78 RID: 23160 RVA: 0x000DC148 File Offset: 0x000DA348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.taskDatas_.CalculateSize(DangoMonopolyTaskUpdateNotify._repeated_taskDatas_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005A79 RID: 23161 RVA: 0x000DC19C File Offset: 0x000DA39C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoMonopolyTaskUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.taskDatas_.Add(other.taskDatas_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005A7A RID: 23162 RVA: 0x000DC1E9 File Offset: 0x000DA3E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005A7B RID: 23163 RVA: 0x000DC1F4 File Offset: 0x000DA3F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num != 34U)
				{
					if (num != 56U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
				}
				else
				{
					this.taskDatas_.AddEntriesFrom(ref input, DangoMonopolyTaskUpdateNotify._repeated_taskDatas_codec);
				}
			}
		}

		// Token: 0x040035B1 RID: 13745
		private UnknownFieldSet _unknownFields;

		// Token: 0x040035B2 RID: 13746
		public const int ActivityIdFieldNumber = 7;

		// Token: 0x040035B3 RID: 13747
		private int activityId_;

		// Token: 0x040035B4 RID: 13748
		public const int TaskDatasFieldNumber = 4;

		// Token: 0x040035B5 RID: 13749
		private static readonly FieldCodec<DangoMonopolyTaskData> _repeated_taskDatas_codec = FieldCodec.ForMessage<DangoMonopolyTaskData>(34U, DangoMonopolyTaskData.Parser);

		// Token: 0x040035B6 RID: 13750
		private readonly RepeatedField<DangoMonopolyTaskData> taskDatas_ = new RepeatedField<DangoMonopolyTaskData>();
	}
}
