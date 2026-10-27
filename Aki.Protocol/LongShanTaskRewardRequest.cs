using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000957 RID: 2391
	[NetMessage(EMessageId.LongShanTaskRewardRequest)]
	public sealed class LongShanTaskRewardRequest : IMessage<LongShanTaskRewardRequest>, IMessage, IEquatable<LongShanTaskRewardRequest>, IDeepCloneable<LongShanTaskRewardRequest>, IBufferMessage
	{
		// Token: 0x0600D2C5 RID: 53957 RVA: 0x001F1242 File Offset: 0x001EF442
		[NullableContext(1)]
		public static LongShanTaskRewardRequest Create()
		{
			return new LongShanTaskRewardRequest();
		}

		// Token: 0x17002AB0 RID: 10928
		// (get) Token: 0x0600D2C6 RID: 53958 RVA: 0x001F1249 File Offset: 0x001EF449
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002AB1 RID: 10929
		// (get) Token: 0x0600D2C7 RID: 53959 RVA: 0x001F124C File Offset: 0x001EF44C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LongShanTaskRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600D2C8 RID: 53960 RVA: 0x001F1253 File Offset: 0x001EF453
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LongShanTaskRewardRequest()
		{
		}

		// Token: 0x0600D2C9 RID: 53961 RVA: 0x001F1266 File Offset: 0x001EF466
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LongShanTaskRewardRequest(LongShanTaskRewardRequest other) : this()
		{
			this.taskIds_ = other.taskIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D2CA RID: 53962 RVA: 0x001F1290 File Offset: 0x001EF490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LongShanTaskRewardRequest Clone()
		{
			return new LongShanTaskRewardRequest(this);
		}

		// Token: 0x17002AB2 RID: 10930
		// (get) Token: 0x0600D2CB RID: 53963 RVA: 0x001F1298 File Offset: 0x001EF498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskIds
		{
			get
			{
				return this.taskIds_;
			}
		}

		// Token: 0x0600D2CC RID: 53964 RVA: 0x001F12A0 File Offset: 0x001EF4A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LongShanTaskRewardRequest);
		}

		// Token: 0x0600D2CD RID: 53965 RVA: 0x001F12AE File Offset: 0x001EF4AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LongShanTaskRewardRequest other)
		{
			return other != null && (other == this || (this.taskIds_.Equals(other.taskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D2CE RID: 53966 RVA: 0x001F12E4 File Offset: 0x001EF4E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.taskIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D2CF RID: 53967 RVA: 0x001F1318 File Offset: 0x001EF518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D2D0 RID: 53968 RVA: 0x001F1325 File Offset: 0x001EF525
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D2D1 RID: 53969 RVA: 0x001F132E File Offset: 0x001EF52E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.taskIds_.WriteTo(ref output, LongShanTaskRewardRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D2D2 RID: 53970 RVA: 0x001F1358 File Offset: 0x001EF558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.taskIds_.CalculateSize(LongShanTaskRewardRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D2D3 RID: 53971 RVA: 0x001F1391 File Offset: 0x001EF591
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LongShanTaskRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.taskIds_.Add(other.taskIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D2D4 RID: 53972 RVA: 0x001F13BF File Offset: 0x001EF5BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D2D5 RID: 53973 RVA: 0x001F13C8 File Offset: 0x001EF5C8
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
				if (num != 72U && num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.taskIds_.AddEntriesFrom(ref input, LongShanTaskRewardRequest._repeated_taskIds_codec);
				}
			}
		}

		// Token: 0x040058AF RID: 22703
		private UnknownFieldSet _unknownFields;

		// Token: 0x040058B0 RID: 22704
		public const int TaskIdsFieldNumber = 9;

		// Token: 0x040058B1 RID: 22705
		private static readonly FieldCodec<int> _repeated_taskIds_codec = FieldCodec.ForInt32(74U);

		// Token: 0x040058B2 RID: 22706
		private readonly RepeatedField<int> taskIds_ = new RepeatedField<int>();
	}
}
