using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003F6 RID: 1014
	[NetMessage(EMessageId.DropCatchLevelRewardResponse)]
	public sealed class DropCatchLevelRewardResponse : IMessage<DropCatchLevelRewardResponse>, IMessage, IEquatable<DropCatchLevelRewardResponse>, IDeepCloneable<DropCatchLevelRewardResponse>, IBufferMessage
	{
		// Token: 0x06006260 RID: 25184 RVA: 0x000ED1CC File Offset: 0x000EB3CC
		[NullableContext(1)]
		public static DropCatchLevelRewardResponse Create()
		{
			return new DropCatchLevelRewardResponse();
		}

		// Token: 0x17001254 RID: 4692
		// (get) Token: 0x06006261 RID: 25185 RVA: 0x000ED1D3 File Offset: 0x000EB3D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001255 RID: 4693
		// (get) Token: 0x06006262 RID: 25186 RVA: 0x000ED1D6 File Offset: 0x000EB3D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DropCatchLevelRewardResponse.Descriptor;
			}
		}

		// Token: 0x06006263 RID: 25187 RVA: 0x000ED1DD File Offset: 0x000EB3DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropCatchLevelRewardResponse()
		{
		}

		// Token: 0x06006264 RID: 25188 RVA: 0x000ED1E5 File Offset: 0x000EB3E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropCatchLevelRewardResponse(DropCatchLevelRewardResponse other) : this()
		{
			this.error_ = other.error_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006265 RID: 25189 RVA: 0x000ED20A File Offset: 0x000EB40A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropCatchLevelRewardResponse Clone()
		{
			return new DropCatchLevelRewardResponse(this);
		}

		// Token: 0x17001256 RID: 4694
		// (get) Token: 0x06006266 RID: 25190 RVA: 0x000ED212 File Offset: 0x000EB412
		// (set) Token: 0x06006267 RID: 25191 RVA: 0x000ED21A File Offset: 0x000EB41A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Error
		{
			get
			{
				return this.error_;
			}
			set
			{
				this.error_ = value;
			}
		}

		// Token: 0x06006268 RID: 25192 RVA: 0x000ED223 File Offset: 0x000EB423
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DropCatchLevelRewardResponse);
		}

		// Token: 0x06006269 RID: 25193 RVA: 0x000ED231 File Offset: 0x000EB431
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DropCatchLevelRewardResponse other)
		{
			return other != null && (other == this || (this.Error == other.Error && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600626A RID: 25194 RVA: 0x000ED260 File Offset: 0x000EB460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Error != ErrorCode.Success)
			{
				num ^= this.Error.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600626B RID: 25195 RVA: 0x000ED2A5 File Offset: 0x000EB4A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600626C RID: 25196 RVA: 0x000ED2B2 File Offset: 0x000EB4B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600626D RID: 25197 RVA: 0x000ED2BB File Offset: 0x000EB4BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Error != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Error);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600626E RID: 25198 RVA: 0x000ED2EC File Offset: 0x000EB4EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Error != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Error);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600626F RID: 25199 RVA: 0x000ED32A File Offset: 0x000EB52A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DropCatchLevelRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Error != ErrorCode.Success)
			{
				this.Error = other.Error;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006270 RID: 25200 RVA: 0x000ED35B File Offset: 0x000EB55B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006271 RID: 25201 RVA: 0x000ED364 File Offset: 0x000EB564
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Error = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003834 RID: 14388
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003835 RID: 14389
		public const int ErrorFieldNumber = 1;

		// Token: 0x04003836 RID: 14390
		private ErrorCode error_;
	}
}
