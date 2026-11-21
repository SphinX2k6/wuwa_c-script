using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000B1 RID: 177
	[NetMessage(EMessageId.AddTemporaryTeleportInfoNotify)]
	public sealed class AddTemporaryTeleportInfoNotify : IMessage<AddTemporaryTeleportInfoNotify>, IMessage, IEquatable<AddTemporaryTeleportInfoNotify>, IDeepCloneable<AddTemporaryTeleportInfoNotify>, IBufferMessage
	{
		// Token: 0x06001DC4 RID: 7620 RVA: 0x00051D9C File Offset: 0x0004FF9C
		[NullableContext(1)]
		public static AddTemporaryTeleportInfoNotify Create()
		{
			return new AddTemporaryTeleportInfoNotify();
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06001DC5 RID: 7621 RVA: 0x00051DA3 File Offset: 0x0004FFA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06001DC6 RID: 7622 RVA: 0x00051DA6 File Offset: 0x0004FFA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddTemporaryTeleportInfoNotify.Descriptor;
			}
		}

		// Token: 0x06001DC7 RID: 7623 RVA: 0x00051DAD File Offset: 0x0004FFAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddTemporaryTeleportInfoNotify()
		{
		}

		// Token: 0x06001DC8 RID: 7624 RVA: 0x00051DB5 File Offset: 0x0004FFB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddTemporaryTeleportInfoNotify(AddTemporaryTeleportInfoNotify other) : this()
		{
			this.temporaryTeleportInfo_ = ((other.temporaryTeleportInfo_ != null) ? other.temporaryTeleportInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001DC9 RID: 7625 RVA: 0x00051DEA File Offset: 0x0004FFEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddTemporaryTeleportInfoNotify Clone()
		{
			return new AddTemporaryTeleportInfoNotify(this);
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06001DCA RID: 7626 RVA: 0x00051DF2 File Offset: 0x0004FFF2
		// (set) Token: 0x06001DCB RID: 7627 RVA: 0x00051DFA File Offset: 0x0004FFFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TemporaryTeleportInfo TemporaryTeleportInfo
		{
			get
			{
				return this.temporaryTeleportInfo_;
			}
			set
			{
				this.temporaryTeleportInfo_ = value;
			}
		}

		// Token: 0x06001DCC RID: 7628 RVA: 0x00051E03 File Offset: 0x00050003
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddTemporaryTeleportInfoNotify);
		}

		// Token: 0x06001DCD RID: 7629 RVA: 0x00051E11 File Offset: 0x00050011
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AddTemporaryTeleportInfoNotify other)
		{
			return other != null && (other == this || (object.Equals(this.TemporaryTeleportInfo, other.TemporaryTeleportInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001DCE RID: 7630 RVA: 0x00051E44 File Offset: 0x00050044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.temporaryTeleportInfo_ != null)
			{
				num ^= this.TemporaryTeleportInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001DCF RID: 7631 RVA: 0x00051E80 File Offset: 0x00050080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001DD0 RID: 7632 RVA: 0x00051E8D File Offset: 0x0005008D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001DD1 RID: 7633 RVA: 0x00051E96 File Offset: 0x00050096
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.temporaryTeleportInfo_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.TemporaryTeleportInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001DD2 RID: 7634 RVA: 0x00051EC8 File Offset: 0x000500C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.temporaryTeleportInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TemporaryTeleportInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001DD3 RID: 7635 RVA: 0x00051F08 File Offset: 0x00050108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AddTemporaryTeleportInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.temporaryTeleportInfo_ != null)
			{
				if (this.temporaryTeleportInfo_ == null)
				{
					this.TemporaryTeleportInfo = new TemporaryTeleportInfo();
				}
				this.TemporaryTeleportInfo.MergeFrom(other.TemporaryTeleportInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001DD4 RID: 7636 RVA: 0x00051F5C File Offset: 0x0005015C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001DD5 RID: 7637 RVA: 0x00051F68 File Offset: 0x00050168
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
				if (num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.temporaryTeleportInfo_ == null)
					{
						this.TemporaryTeleportInfo = new TemporaryTeleportInfo();
					}
					input.ReadMessage(this.TemporaryTeleportInfo);
				}
			}
		}

		// Token: 0x04002382 RID: 9090
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002383 RID: 9091
		public const int TemporaryTeleportInfoFieldNumber = 5;

		// Token: 0x04002384 RID: 9092
		private TemporaryTeleportInfo temporaryTeleportInfo_;
	}
}
