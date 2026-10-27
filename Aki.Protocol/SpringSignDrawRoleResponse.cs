using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001280 RID: 4736
	[NetMessage(EMessageId.SpringSignDrawRoleResponse)]
	public sealed class SpringSignDrawRoleResponse : IMessage<SpringSignDrawRoleResponse>, IMessage, IEquatable<SpringSignDrawRoleResponse>, IDeepCloneable<SpringSignDrawRoleResponse>, IBufferMessage
	{
		// Token: 0x06019396 RID: 103318 RVA: 0x003AB61E File Offset: 0x003A981E
		[NullableContext(1)]
		public static SpringSignDrawRoleResponse Create()
		{
			return new SpringSignDrawRoleResponse();
		}

		// Token: 0x17005518 RID: 21784
		// (get) Token: 0x06019397 RID: 103319 RVA: 0x003AB625 File Offset: 0x003A9825
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005519 RID: 21785
		// (get) Token: 0x06019398 RID: 103320 RVA: 0x003AB628 File Offset: 0x003A9828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpringSignDrawRoleResponse.Descriptor;
			}
		}

		// Token: 0x06019399 RID: 103321 RVA: 0x003AB62F File Offset: 0x003A982F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringSignDrawRoleResponse()
		{
		}

		// Token: 0x0601939A RID: 103322 RVA: 0x003AB637 File Offset: 0x003A9837
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringSignDrawRoleResponse(SpringSignDrawRoleResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.drawId_ = other.drawId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601939B RID: 103323 RVA: 0x003AB668 File Offset: 0x003A9868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringSignDrawRoleResponse Clone()
		{
			return new SpringSignDrawRoleResponse(this);
		}

		// Token: 0x1700551A RID: 21786
		// (get) Token: 0x0601939C RID: 103324 RVA: 0x003AB670 File Offset: 0x003A9870
		// (set) Token: 0x0601939D RID: 103325 RVA: 0x003AB678 File Offset: 0x003A9878
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

		// Token: 0x1700551B RID: 21787
		// (get) Token: 0x0601939E RID: 103326 RVA: 0x003AB681 File Offset: 0x003A9881
		// (set) Token: 0x0601939F RID: 103327 RVA: 0x003AB689 File Offset: 0x003A9889
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DrawId
		{
			get
			{
				return this.drawId_;
			}
			set
			{
				this.drawId_ = value;
			}
		}

		// Token: 0x060193A0 RID: 103328 RVA: 0x003AB692 File Offset: 0x003A9892
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpringSignDrawRoleResponse);
		}

		// Token: 0x060193A1 RID: 103329 RVA: 0x003AB6A0 File Offset: 0x003A98A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpringSignDrawRoleResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.DrawId == other.DrawId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060193A2 RID: 103330 RVA: 0x003AB6E0 File Offset: 0x003A98E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.DrawId != 0)
			{
				num ^= this.DrawId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060193A3 RID: 103331 RVA: 0x003AB73E File Offset: 0x003A993E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060193A4 RID: 103332 RVA: 0x003AB74B File Offset: 0x003A994B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060193A5 RID: 103333 RVA: 0x003AB754 File Offset: 0x003A9954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DrawId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.DrawId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060193A6 RID: 103334 RVA: 0x003AB7AC File Offset: 0x003A99AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.DrawId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DrawId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060193A7 RID: 103335 RVA: 0x003AB804 File Offset: 0x003A9A04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SpringSignDrawRoleResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.DrawId != 0)
			{
				this.DrawId = other.DrawId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060193A8 RID: 103336 RVA: 0x003AB854 File Offset: 0x003A9A54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060193A9 RID: 103337 RVA: 0x003AB860 File Offset: 0x003A9A60
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
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.DrawId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009469 RID: 37993
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400946A RID: 37994
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x0400946B RID: 37995
		private ErrorCode errorCode_;

		// Token: 0x0400946C RID: 37996
		public const int DrawIdFieldNumber = 1;

		// Token: 0x0400946D RID: 37997
		private int drawId_;
	}
}
