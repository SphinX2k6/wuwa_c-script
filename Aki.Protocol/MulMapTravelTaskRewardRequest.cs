using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AD1 RID: 2769
	[NetMessage(EMessageId.MulMapTravelTaskRewardRequest)]
	public sealed class MulMapTravelTaskRewardRequest : IMessage<MulMapTravelTaskRewardRequest>, IMessage, IEquatable<MulMapTravelTaskRewardRequest>, IDeepCloneable<MulMapTravelTaskRewardRequest>, IBufferMessage
	{
		// Token: 0x0600F13D RID: 61757 RVA: 0x00233FB4 File Offset: 0x002321B4
		[NullableContext(1)]
		public static MulMapTravelTaskRewardRequest Create()
		{
			return new MulMapTravelTaskRewardRequest();
		}

		// Token: 0x17003119 RID: 12569
		// (get) Token: 0x0600F13E RID: 61758 RVA: 0x00233FBB File Offset: 0x002321BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700311A RID: 12570
		// (get) Token: 0x0600F13F RID: 61759 RVA: 0x00233FBE File Offset: 0x002321BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MulMapTravelTaskRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600F140 RID: 61760 RVA: 0x00233FC5 File Offset: 0x002321C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulMapTravelTaskRewardRequest()
		{
		}

		// Token: 0x0600F141 RID: 61761 RVA: 0x00233FD8 File Offset: 0x002321D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulMapTravelTaskRewardRequest(MulMapTravelTaskRewardRequest other) : this()
		{
			this.taskId_ = other.taskId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F142 RID: 61762 RVA: 0x00234002 File Offset: 0x00232202
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulMapTravelTaskRewardRequest Clone()
		{
			return new MulMapTravelTaskRewardRequest(this);
		}

		// Token: 0x1700311B RID: 12571
		// (get) Token: 0x0600F143 RID: 61763 RVA: 0x0023400A File Offset: 0x0023220A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskId
		{
			get
			{
				return this.taskId_;
			}
		}

		// Token: 0x0600F144 RID: 61764 RVA: 0x00234012 File Offset: 0x00232212
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MulMapTravelTaskRewardRequest);
		}

		// Token: 0x0600F145 RID: 61765 RVA: 0x00234020 File Offset: 0x00232220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MulMapTravelTaskRewardRequest other)
		{
			return other != null && (other == this || (this.taskId_.Equals(other.taskId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F146 RID: 61766 RVA: 0x00234054 File Offset: 0x00232254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.taskId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F147 RID: 61767 RVA: 0x00234088 File Offset: 0x00232288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F148 RID: 61768 RVA: 0x00234095 File Offset: 0x00232295
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F149 RID: 61769 RVA: 0x0023409E File Offset: 0x0023229E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.taskId_.WriteTo(ref output, MulMapTravelTaskRewardRequest._repeated_taskId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F14A RID: 61770 RVA: 0x002340C8 File Offset: 0x002322C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.taskId_.CalculateSize(MulMapTravelTaskRewardRequest._repeated_taskId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F14B RID: 61771 RVA: 0x00234101 File Offset: 0x00232301
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MulMapTravelTaskRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.taskId_.Add(other.taskId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F14C RID: 61772 RVA: 0x0023412F File Offset: 0x0023232F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F14D RID: 61773 RVA: 0x00234138 File Offset: 0x00232338
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
				if (num != 112U && num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.taskId_.AddEntriesFrom(ref input, MulMapTravelTaskRewardRequest._repeated_taskId_codec);
				}
			}
		}

		// Token: 0x040061CF RID: 25039
		private UnknownFieldSet _unknownFields;

		// Token: 0x040061D0 RID: 25040
		public const int TaskIdFieldNumber = 14;

		// Token: 0x040061D1 RID: 25041
		private static readonly FieldCodec<int> _repeated_taskId_codec = FieldCodec.ForInt32(114U);

		// Token: 0x040061D2 RID: 25042
		private readonly RepeatedField<int> taskId_ = new RepeatedField<int>();
	}
}
