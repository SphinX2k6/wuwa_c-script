using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000741 RID: 1857
	[NetMessage(EMessageId.HarvestActivityLevelDiffResponse)]
	public sealed class HarvestActivityLevelDiffResponse : IMessage<HarvestActivityLevelDiffResponse>, IMessage, IEquatable<HarvestActivityLevelDiffResponse>, IDeepCloneable<HarvestActivityLevelDiffResponse>, IBufferMessage
	{
		// Token: 0x0600A844 RID: 43076 RVA: 0x00194E3F File Offset: 0x0019303F
		[NullableContext(1)]
		public static HarvestActivityLevelDiffResponse Create()
		{
			return new HarvestActivityLevelDiffResponse();
		}

		// Token: 0x170021D6 RID: 8662
		// (get) Token: 0x0600A845 RID: 43077 RVA: 0x00194E46 File Offset: 0x00193046
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170021D7 RID: 8663
		// (get) Token: 0x0600A846 RID: 43078 RVA: 0x00194E49 File Offset: 0x00193049
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HarvestActivityLevelDiffResponse.Descriptor;
			}
		}

		// Token: 0x0600A847 RID: 43079 RVA: 0x00194E50 File Offset: 0x00193050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivityLevelDiffResponse()
		{
		}

		// Token: 0x0600A848 RID: 43080 RVA: 0x00194E58 File Offset: 0x00193058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivityLevelDiffResponse(HarvestActivityLevelDiffResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A849 RID: 43081 RVA: 0x00194E7D File Offset: 0x0019307D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivityLevelDiffResponse Clone()
		{
			return new HarvestActivityLevelDiffResponse(this);
		}

		// Token: 0x170021D8 RID: 8664
		// (get) Token: 0x0600A84A RID: 43082 RVA: 0x00194E85 File Offset: 0x00193085
		// (set) Token: 0x0600A84B RID: 43083 RVA: 0x00194E8D File Offset: 0x0019308D
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

		// Token: 0x0600A84C RID: 43084 RVA: 0x00194E96 File Offset: 0x00193096
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HarvestActivityLevelDiffResponse);
		}

		// Token: 0x0600A84D RID: 43085 RVA: 0x00194EA4 File Offset: 0x001930A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HarvestActivityLevelDiffResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A84E RID: 43086 RVA: 0x00194ED4 File Offset: 0x001930D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A84F RID: 43087 RVA: 0x00194F19 File Offset: 0x00193119
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A850 RID: 43088 RVA: 0x00194F26 File Offset: 0x00193126
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A851 RID: 43089 RVA: 0x00194F2F File Offset: 0x0019312F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A852 RID: 43090 RVA: 0x00194F64 File Offset: 0x00193164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A853 RID: 43091 RVA: 0x00194FA2 File Offset: 0x001931A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HarvestActivityLevelDiffResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A854 RID: 43092 RVA: 0x00194FD3 File Offset: 0x001931D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A855 RID: 43093 RVA: 0x00194FDC File Offset: 0x001931DC
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004CCB RID: 19659
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004CCC RID: 19660
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x04004CCD RID: 19661
		private ErrorCode errorCode_;
	}
}
