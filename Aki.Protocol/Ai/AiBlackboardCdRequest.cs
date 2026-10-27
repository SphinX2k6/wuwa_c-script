using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Ai
{
	// Token: 0x020016A5 RID: 5797
	[NetMessage(EMessageId.AiBlackboardCdRequest)]
	public sealed class AiBlackboardCdRequest : IMessage<AiBlackboardCdRequest>, IMessage, IEquatable<AiBlackboardCdRequest>, IDeepCloneable<AiBlackboardCdRequest>, IBufferMessage
	{
		// Token: 0x0601D0CA RID: 118986 RVA: 0x00440866 File Offset: 0x0043EA66
		[NullableContext(1)]
		public static AiBlackboardCdRequest Create()
		{
			return new AiBlackboardCdRequest();
		}

		// Token: 0x17006293 RID: 25235
		// (get) Token: 0x0601D0CB RID: 118987 RVA: 0x0044086D File Offset: 0x0043EA6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006294 RID: 25236
		// (get) Token: 0x0601D0CC RID: 118988 RVA: 0x00440870 File Offset: 0x0043EA70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AiBlackboardCdRequest.Descriptor;
			}
		}

		// Token: 0x0601D0CD RID: 118989 RVA: 0x00440877 File Offset: 0x0043EA77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiBlackboardCdRequest()
		{
		}

		// Token: 0x0601D0CE RID: 118990 RVA: 0x00440895 File Offset: 0x0043EA95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiBlackboardCdRequest(AiBlackboardCdRequest other) : this()
		{
			this.aiBlackboardCdModify_ = other.aiBlackboardCdModify_.Clone();
			this.aiBlackboardCdComplete_ = other.aiBlackboardCdComplete_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D0CF RID: 118991 RVA: 0x004408D0 File Offset: 0x0043EAD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiBlackboardCdRequest Clone()
		{
			return new AiBlackboardCdRequest(this);
		}

		// Token: 0x17006295 RID: 25237
		// (get) Token: 0x0601D0D0 RID: 118992 RVA: 0x004408D8 File Offset: 0x0043EAD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Int2Long> AiBlackboardCdModify
		{
			get
			{
				return this.aiBlackboardCdModify_;
			}
		}

		// Token: 0x17006296 RID: 25238
		// (get) Token: 0x0601D0D1 RID: 118993 RVA: 0x004408E0 File Offset: 0x0043EAE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Int2Bool> AiBlackboardCdComplete
		{
			get
			{
				return this.aiBlackboardCdComplete_;
			}
		}

		// Token: 0x0601D0D2 RID: 118994 RVA: 0x004408E8 File Offset: 0x0043EAE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AiBlackboardCdRequest);
		}

		// Token: 0x0601D0D3 RID: 118995 RVA: 0x004408F8 File Offset: 0x0043EAF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AiBlackboardCdRequest other)
		{
			return other != null && (other == this || (this.aiBlackboardCdModify_.Equals(other.aiBlackboardCdModify_) && this.aiBlackboardCdComplete_.Equals(other.aiBlackboardCdComplete_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D0D4 RID: 118996 RVA: 0x0044094C File Offset: 0x0043EB4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.aiBlackboardCdModify_.GetHashCode();
			num ^= this.aiBlackboardCdComplete_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D0D5 RID: 118997 RVA: 0x0044098E File Offset: 0x0043EB8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D0D6 RID: 118998 RVA: 0x0044099B File Offset: 0x0043EB9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D0D7 RID: 118999 RVA: 0x004409A4 File Offset: 0x0043EBA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.aiBlackboardCdModify_.WriteTo(ref output, AiBlackboardCdRequest._repeated_aiBlackboardCdModify_codec);
			this.aiBlackboardCdComplete_.WriteTo(ref output, AiBlackboardCdRequest._repeated_aiBlackboardCdComplete_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D0D8 RID: 119000 RVA: 0x004409DC File Offset: 0x0043EBDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.aiBlackboardCdModify_.CalculateSize(AiBlackboardCdRequest._repeated_aiBlackboardCdModify_codec);
			num += this.aiBlackboardCdComplete_.CalculateSize(AiBlackboardCdRequest._repeated_aiBlackboardCdComplete_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D0D9 RID: 119001 RVA: 0x00440A28 File Offset: 0x0043EC28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AiBlackboardCdRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.aiBlackboardCdModify_.Add(other.aiBlackboardCdModify_);
			this.aiBlackboardCdComplete_.Add(other.aiBlackboardCdComplete_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D0DA RID: 119002 RVA: 0x00440A67 File Offset: 0x0043EC67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D0DB RID: 119003 RVA: 0x00440A70 File Offset: 0x0043EC70
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
					if (num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.aiBlackboardCdComplete_.AddEntriesFrom(ref input, AiBlackboardCdRequest._repeated_aiBlackboardCdComplete_codec);
					}
				}
				else
				{
					this.aiBlackboardCdModify_.AddEntriesFrom(ref input, AiBlackboardCdRequest._repeated_aiBlackboardCdModify_codec);
				}
			}
		}

		// Token: 0x0400C413 RID: 50195
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C414 RID: 50196
		public const int AiBlackboardCdModifyFieldNumber = 4;

		// Token: 0x0400C415 RID: 50197
		private static readonly FieldCodec<Int2Long> _repeated_aiBlackboardCdModify_codec = FieldCodec.ForMessage<Int2Long>(34U, Int2Long.Parser);

		// Token: 0x0400C416 RID: 50198
		private readonly RepeatedField<Int2Long> aiBlackboardCdModify_ = new RepeatedField<Int2Long>();

		// Token: 0x0400C417 RID: 50199
		public const int AiBlackboardCdCompleteFieldNumber = 13;

		// Token: 0x0400C418 RID: 50200
		private static readonly FieldCodec<Int2Bool> _repeated_aiBlackboardCdComplete_codec = FieldCodec.ForMessage<Int2Bool>(106U, Int2Bool.Parser);

		// Token: 0x0400C419 RID: 50201
		private readonly RepeatedField<Int2Bool> aiBlackboardCdComplete_ = new RepeatedField<Int2Bool>();
	}
}
