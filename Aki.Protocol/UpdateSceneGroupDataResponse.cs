using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014AA RID: 5290
	[NetMessage(EMessageId.UpdateSceneGroupDataResponse)]
	public sealed class UpdateSceneGroupDataResponse : IMessage<UpdateSceneGroupDataResponse>, IMessage, IEquatable<UpdateSceneGroupDataResponse>, IDeepCloneable<UpdateSceneGroupDataResponse>, IBufferMessage
	{
		// Token: 0x0601BFA3 RID: 114595 RVA: 0x0040B32B File Offset: 0x0040952B
		[NullableContext(1)]
		public static UpdateSceneGroupDataResponse Create()
		{
			return new UpdateSceneGroupDataResponse();
		}

		// Token: 0x17005E49 RID: 24137
		// (get) Token: 0x0601BFA4 RID: 114596 RVA: 0x0040B332 File Offset: 0x00409532
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005E4A RID: 24138
		// (get) Token: 0x0601BFA5 RID: 114597 RVA: 0x0040B335 File Offset: 0x00409535
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateSceneGroupDataResponse.Descriptor;
			}
		}

		// Token: 0x0601BFA6 RID: 114598 RVA: 0x0040B33C File Offset: 0x0040953C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateSceneGroupDataResponse()
		{
		}

		// Token: 0x0601BFA7 RID: 114599 RVA: 0x0040B344 File Offset: 0x00409544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateSceneGroupDataResponse(UpdateSceneGroupDataResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BFA8 RID: 114600 RVA: 0x0040B369 File Offset: 0x00409569
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateSceneGroupDataResponse Clone()
		{
			return new UpdateSceneGroupDataResponse(this);
		}

		// Token: 0x17005E4B RID: 24139
		// (get) Token: 0x0601BFA9 RID: 114601 RVA: 0x0040B371 File Offset: 0x00409571
		// (set) Token: 0x0601BFAA RID: 114602 RVA: 0x0040B379 File Offset: 0x00409579
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

		// Token: 0x0601BFAB RID: 114603 RVA: 0x0040B382 File Offset: 0x00409582
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateSceneGroupDataResponse);
		}

		// Token: 0x0601BFAC RID: 114604 RVA: 0x0040B390 File Offset: 0x00409590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateSceneGroupDataResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BFAD RID: 114605 RVA: 0x0040B3C0 File Offset: 0x004095C0
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

		// Token: 0x0601BFAE RID: 114606 RVA: 0x0040B405 File Offset: 0x00409605
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BFAF RID: 114607 RVA: 0x0040B412 File Offset: 0x00409612
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BFB0 RID: 114608 RVA: 0x0040B41B File Offset: 0x0040961B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BFB1 RID: 114609 RVA: 0x0040B450 File Offset: 0x00409650
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

		// Token: 0x0601BFB2 RID: 114610 RVA: 0x0040B48E File Offset: 0x0040968E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdateSceneGroupDataResponse other)
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

		// Token: 0x0601BFB3 RID: 114611 RVA: 0x0040B4BF File Offset: 0x004096BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BFB4 RID: 114612 RVA: 0x0040B4C8 File Offset: 0x004096C8
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A0B8 RID: 41144
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A0B9 RID: 41145
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x0400A0BA RID: 41146
		private ErrorCode errorCode_;
	}
}
