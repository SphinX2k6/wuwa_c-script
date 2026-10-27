using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200108D RID: 4237
	[NetMessage(EMessageId.RoleMotionActiveNotify)]
	public sealed class RoleMotionActiveNotify : IMessage<RoleMotionActiveNotify>, IMessage, IEquatable<RoleMotionActiveNotify>, IDeepCloneable<RoleMotionActiveNotify>, IBufferMessage
	{
		// Token: 0x06016A33 RID: 92723 RVA: 0x0034A90D File Offset: 0x00348B0D
		[NullableContext(1)]
		public static RoleMotionActiveNotify Create()
		{
			return new RoleMotionActiveNotify();
		}

		// Token: 0x17004BD8 RID: 19416
		// (get) Token: 0x06016A34 RID: 92724 RVA: 0x0034A914 File Offset: 0x00348B14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004BD9 RID: 19417
		// (get) Token: 0x06016A35 RID: 92725 RVA: 0x0034A917 File Offset: 0x00348B17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleMotionActiveNotify.Descriptor;
			}
		}

		// Token: 0x06016A36 RID: 92726 RVA: 0x0034A91E File Offset: 0x00348B1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleMotionActiveNotify()
		{
		}

		// Token: 0x06016A37 RID: 92727 RVA: 0x0034A926 File Offset: 0x00348B26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleMotionActiveNotify(RoleMotionActiveNotify other) : this()
		{
			this.roleMotionInfo_ = ((other.roleMotionInfo_ != null) ? other.roleMotionInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016A38 RID: 92728 RVA: 0x0034A95B File Offset: 0x00348B5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleMotionActiveNotify Clone()
		{
			return new RoleMotionActiveNotify(this);
		}

		// Token: 0x17004BDA RID: 19418
		// (get) Token: 0x06016A39 RID: 92729 RVA: 0x0034A963 File Offset: 0x00348B63
		// (set) Token: 0x06016A3A RID: 92730 RVA: 0x0034A96B File Offset: 0x00348B6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleMotion RoleMotionInfo
		{
			get
			{
				return this.roleMotionInfo_;
			}
			set
			{
				this.roleMotionInfo_ = value;
			}
		}

		// Token: 0x06016A3B RID: 92731 RVA: 0x0034A974 File Offset: 0x00348B74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleMotionActiveNotify);
		}

		// Token: 0x06016A3C RID: 92732 RVA: 0x0034A982 File Offset: 0x00348B82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleMotionActiveNotify other)
		{
			return other != null && (other == this || (object.Equals(this.RoleMotionInfo, other.RoleMotionInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016A3D RID: 92733 RVA: 0x0034A9B8 File Offset: 0x00348BB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.roleMotionInfo_ != null)
			{
				num ^= this.RoleMotionInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016A3E RID: 92734 RVA: 0x0034A9F4 File Offset: 0x00348BF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016A3F RID: 92735 RVA: 0x0034AA01 File Offset: 0x00348C01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016A40 RID: 92736 RVA: 0x0034AA0A File Offset: 0x00348C0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.roleMotionInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.RoleMotionInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016A41 RID: 92737 RVA: 0x0034AA3C File Offset: 0x00348C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.roleMotionInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RoleMotionInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016A42 RID: 92738 RVA: 0x0034AA7C File Offset: 0x00348C7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleMotionActiveNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.roleMotionInfo_ != null)
			{
				if (this.roleMotionInfo_ == null)
				{
					this.RoleMotionInfo = new RoleMotion();
				}
				this.RoleMotionInfo.MergeFrom(other.RoleMotionInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016A43 RID: 92739 RVA: 0x0034AAD0 File Offset: 0x00348CD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016A44 RID: 92740 RVA: 0x0034AADC File Offset: 0x00348CDC
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.roleMotionInfo_ == null)
					{
						this.RoleMotionInfo = new RoleMotion();
					}
					input.ReadMessage(this.RoleMotionInfo);
				}
			}
		}

		// Token: 0x04008755 RID: 34645
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008756 RID: 34646
		public const int RoleMotionInfoFieldNumber = 1;

		// Token: 0x04008757 RID: 34647
		private RoleMotion roleMotionInfo_;
	}
}
