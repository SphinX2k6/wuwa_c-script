using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005CB RID: 1483
	[NetMessage(EMessageId.FloroRanchPlaySelectCardGroupResponse)]
	public sealed class FloroRanchPlaySelectCardGroupResponse : IMessage<FloroRanchPlaySelectCardGroupResponse>, IMessage, IEquatable<FloroRanchPlaySelectCardGroupResponse>, IDeepCloneable<FloroRanchPlaySelectCardGroupResponse>, IBufferMessage
	{
		// Token: 0x06008906 RID: 35078 RVA: 0x0014A2DE File Offset: 0x001484DE
		[NullableContext(1)]
		public static FloroRanchPlaySelectCardGroupResponse Create()
		{
			return new FloroRanchPlaySelectCardGroupResponse();
		}

		// Token: 0x17001AE3 RID: 6883
		// (get) Token: 0x06008907 RID: 35079 RVA: 0x0014A2E5 File Offset: 0x001484E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001AE4 RID: 6884
		// (get) Token: 0x06008908 RID: 35080 RVA: 0x0014A2E8 File Offset: 0x001484E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchPlaySelectCardGroupResponse.Descriptor;
			}
		}

		// Token: 0x06008909 RID: 35081 RVA: 0x0014A2EF File Offset: 0x001484EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlaySelectCardGroupResponse()
		{
		}

		// Token: 0x0600890A RID: 35082 RVA: 0x0014A302 File Offset: 0x00148502
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlaySelectCardGroupResponse(FloroRanchPlaySelectCardGroupResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.newPhantoms_ = other.newPhantoms_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600890B RID: 35083 RVA: 0x0014A338 File Offset: 0x00148538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlaySelectCardGroupResponse Clone()
		{
			return new FloroRanchPlaySelectCardGroupResponse(this);
		}

		// Token: 0x17001AE5 RID: 6885
		// (get) Token: 0x0600890C RID: 35084 RVA: 0x0014A340 File Offset: 0x00148540
		// (set) Token: 0x0600890D RID: 35085 RVA: 0x0014A348 File Offset: 0x00148548
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x17001AE6 RID: 6886
		// (get) Token: 0x0600890E RID: 35086 RVA: 0x0014A351 File Offset: 0x00148551
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FloroRanchPlayUnit> NewPhantoms
		{
			get
			{
				return this.newPhantoms_;
			}
		}

		// Token: 0x0600890F RID: 35087 RVA: 0x0014A359 File Offset: 0x00148559
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchPlaySelectCardGroupResponse);
		}

		// Token: 0x06008910 RID: 35088 RVA: 0x0014A368 File Offset: 0x00148568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchPlaySelectCardGroupResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.newPhantoms_.Equals(other.newPhantoms_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008911 RID: 35089 RVA: 0x0014A3B8 File Offset: 0x001485B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.newPhantoms_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008912 RID: 35090 RVA: 0x0014A40B File Offset: 0x0014860B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008913 RID: 35091 RVA: 0x0014A418 File Offset: 0x00148618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008914 RID: 35092 RVA: 0x0014A424 File Offset: 0x00148624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.newPhantoms_.WriteTo(ref output, FloroRanchPlaySelectCardGroupResponse._repeated_newPhantoms_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008915 RID: 35093 RVA: 0x0014A474 File Offset: 0x00148674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.newPhantoms_.CalculateSize(FloroRanchPlaySelectCardGroupResponse._repeated_newPhantoms_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008916 RID: 35094 RVA: 0x0014A4C8 File Offset: 0x001486C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchPlaySelectCardGroupResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.newPhantoms_.Add(other.newPhantoms_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008917 RID: 35095 RVA: 0x0014A515 File Offset: 0x00148715
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008918 RID: 35096 RVA: 0x0014A520 File Offset: 0x00148720
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
				if (num != 8U)
				{
					if (num != 98U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.newPhantoms_.AddEntriesFrom(ref input, FloroRanchPlaySelectCardGroupResponse._repeated_newPhantoms_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004362 RID: 17250
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004363 RID: 17251
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04004364 RID: 17252
		private ErrorCode errorCode_;

		// Token: 0x04004365 RID: 17253
		public const int NewPhantomsFieldNumber = 12;

		// Token: 0x04004366 RID: 17254
		private static readonly FieldCodec<FloroRanchPlayUnit> _repeated_newPhantoms_codec = FieldCodec.ForMessage<FloroRanchPlayUnit>(98U, FloroRanchPlayUnit.Parser);

		// Token: 0x04004367 RID: 17255
		private readonly RepeatedField<FloroRanchPlayUnit> newPhantoms_ = new RepeatedField<FloroRanchPlayUnit>();
	}
}
