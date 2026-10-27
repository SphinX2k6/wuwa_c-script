using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AB5 RID: 2741
	[NetMessage(EMessageId.MotorUseSkinRequest)]
	public sealed class MotorUseSkinRequest : IMessage<MotorUseSkinRequest>, IMessage, IEquatable<MotorUseSkinRequest>, IDeepCloneable<MotorUseSkinRequest>, IBufferMessage
	{
		// Token: 0x0600EE7F RID: 61055 RVA: 0x0022CC04 File Offset: 0x0022AE04
		[NullableContext(1)]
		public static MotorUseSkinRequest Create()
		{
			return new MotorUseSkinRequest();
		}

		// Token: 0x17003074 RID: 12404
		// (get) Token: 0x0600EE80 RID: 61056 RVA: 0x0022CC0B File Offset: 0x0022AE0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003075 RID: 12405
		// (get) Token: 0x0600EE81 RID: 61057 RVA: 0x0022CC0E File Offset: 0x0022AE0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorUseSkinRequest.Descriptor;
			}
		}

		// Token: 0x0600EE82 RID: 61058 RVA: 0x0022CC15 File Offset: 0x0022AE15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorUseSkinRequest()
		{
		}

		// Token: 0x0600EE83 RID: 61059 RVA: 0x0022CC1D File Offset: 0x0022AE1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorUseSkinRequest(MotorUseSkinRequest other) : this()
		{
			this.skinId_ = other.skinId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EE84 RID: 61060 RVA: 0x0022CC42 File Offset: 0x0022AE42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorUseSkinRequest Clone()
		{
			return new MotorUseSkinRequest(this);
		}

		// Token: 0x17003076 RID: 12406
		// (get) Token: 0x0600EE85 RID: 61061 RVA: 0x0022CC4A File Offset: 0x0022AE4A
		// (set) Token: 0x0600EE86 RID: 61062 RVA: 0x0022CC52 File Offset: 0x0022AE52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkinId
		{
			get
			{
				return this.skinId_;
			}
			set
			{
				this.skinId_ = value;
			}
		}

		// Token: 0x0600EE87 RID: 61063 RVA: 0x0022CC5B File Offset: 0x0022AE5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorUseSkinRequest);
		}

		// Token: 0x0600EE88 RID: 61064 RVA: 0x0022CC69 File Offset: 0x0022AE69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorUseSkinRequest other)
		{
			return other != null && (other == this || (this.SkinId == other.SkinId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EE89 RID: 61065 RVA: 0x0022CC98 File Offset: 0x0022AE98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SkinId != 0)
			{
				num ^= this.SkinId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600EE8A RID: 61066 RVA: 0x0022CCD7 File Offset: 0x0022AED7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EE8B RID: 61067 RVA: 0x0022CCE4 File Offset: 0x0022AEE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EE8C RID: 61068 RVA: 0x0022CCED File Offset: 0x0022AEED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkinId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.SkinId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EE8D RID: 61069 RVA: 0x0022CD20 File Offset: 0x0022AF20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SkinId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkinId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600EE8E RID: 61070 RVA: 0x0022CD5E File Offset: 0x0022AF5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorUseSkinRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SkinId != 0)
			{
				this.SkinId = other.SkinId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600EE8F RID: 61071 RVA: 0x0022CD8F File Offset: 0x0022AF8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EE90 RID: 61072 RVA: 0x0022CD98 File Offset: 0x0022AF98
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SkinId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006073 RID: 24691
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006074 RID: 24692
		public const int SkinIdFieldNumber = 15;

		// Token: 0x04006075 RID: 24693
		private int skinId_;
	}
}
