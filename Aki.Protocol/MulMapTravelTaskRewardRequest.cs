using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AE2 RID: 2786
	[NetMessage(EMessageId.MulMapTravelTaskRewardRequest)]
	public sealed class MulMapTravelTaskRewardRequest : IMessage<MulMapTravelTaskRewardRequest>, IMessage, IEquatable<MulMapTravelTaskRewardRequest>, IDeepCloneable<MulMapTravelTaskRewardRequest>, IBufferMessage
	{
		// Token: 0x0600F257 RID: 62039 RVA: 0x002361C0 File Offset: 0x002343C0
		[NullableContext(1)]
		public static MulMapTravelTaskRewardRequest Create()
		{
			return new MulMapTravelTaskRewardRequest();
		}

		// Token: 0x17003157 RID: 12631
		// (get) Token: 0x0600F258 RID: 62040 RVA: 0x002361C7 File Offset: 0x002343C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003158 RID: 12632
		// (get) Token: 0x0600F259 RID: 62041 RVA: 0x002361CA File Offset: 0x002343CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MulMapTravelTaskRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600F25A RID: 62042 RVA: 0x002361D1 File Offset: 0x002343D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulMapTravelTaskRewardRequest()
		{
		}

		// Token: 0x0600F25B RID: 62043 RVA: 0x002361E4 File Offset: 0x002343E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulMapTravelTaskRewardRequest(MulMapTravelTaskRewardRequest other) : this()
		{
			this.taskId_ = other.taskId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F25C RID: 62044 RVA: 0x0023620E File Offset: 0x0023440E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulMapTravelTaskRewardRequest Clone()
		{
			return new MulMapTravelTaskRewardRequest(this);
		}

		// Token: 0x17003159 RID: 12633
		// (get) Token: 0x0600F25D RID: 62045 RVA: 0x00236216 File Offset: 0x00234416
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskId
		{
			get
			{
				return this.taskId_;
			}
		}

		// Token: 0x0600F25E RID: 62046 RVA: 0x0023621E File Offset: 0x0023441E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MulMapTravelTaskRewardRequest);
		}

		// Token: 0x0600F25F RID: 62047 RVA: 0x0023622C File Offset: 0x0023442C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MulMapTravelTaskRewardRequest other)
		{
			return other != null && (other == this || (this.taskId_.Equals(other.taskId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F260 RID: 62048 RVA: 0x00236260 File Offset: 0x00234460
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

		// Token: 0x0600F261 RID: 62049 RVA: 0x00236294 File Offset: 0x00234494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F262 RID: 62050 RVA: 0x002362A1 File Offset: 0x002344A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F263 RID: 62051 RVA: 0x002362AA File Offset: 0x002344AA
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

		// Token: 0x0600F264 RID: 62052 RVA: 0x002362D4 File Offset: 0x002344D4
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

		// Token: 0x0600F265 RID: 62053 RVA: 0x0023630D File Offset: 0x0023450D
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

		// Token: 0x0600F266 RID: 62054 RVA: 0x0023633B File Offset: 0x0023453B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F267 RID: 62055 RVA: 0x00236344 File Offset: 0x00234544
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
				if (num != 32U && num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.taskId_.AddEntriesFrom(ref input, MulMapTravelTaskRewardRequest._repeated_taskId_codec);
				}
			}
		}

		// Token: 0x040061C6 RID: 25030
		private UnknownFieldSet _unknownFields;

		// Token: 0x040061C7 RID: 25031
		public const int TaskIdFieldNumber = 4;

		// Token: 0x040061C8 RID: 25032
		private static readonly FieldCodec<int> _repeated_taskId_codec = FieldCodec.ForInt32(34U);

		// Token: 0x040061C9 RID: 25033
		private readonly RepeatedField<int> taskId_ = new RepeatedField<int>();
	}
}
