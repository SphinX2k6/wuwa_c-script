using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000B0 RID: 176
	[NetMessage(EMessageId.AddTemporaryTeleportInfoNotify)]
	public sealed class AddTemporaryTeleportInfoNotify : IMessage<AddTemporaryTeleportInfoNotify>, IMessage, IEquatable<AddTemporaryTeleportInfoNotify>, IDeepCloneable<AddTemporaryTeleportInfoNotify>, IBufferMessage
	{
		// Token: 0x06001D7B RID: 7547 RVA: 0x000510E8 File Offset: 0x0004F2E8
		[NullableContext(1)]
		public static AddTemporaryTeleportInfoNotify Create()
		{
			return new AddTemporaryTeleportInfoNotify();
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06001D7C RID: 7548 RVA: 0x000510EF File Offset: 0x0004F2EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06001D7D RID: 7549 RVA: 0x000510F2 File Offset: 0x0004F2F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddTemporaryTeleportInfoNotify.Descriptor;
			}
		}

		// Token: 0x06001D7E RID: 7550 RVA: 0x000510F9 File Offset: 0x0004F2F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddTemporaryTeleportInfoNotify()
		{
		}

		// Token: 0x06001D7F RID: 7551 RVA: 0x00051101 File Offset: 0x0004F301
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddTemporaryTeleportInfoNotify(AddTemporaryTeleportInfoNotify other) : this()
		{
			this.temporaryTeleportInfo_ = ((other.temporaryTeleportInfo_ != null) ? other.temporaryTeleportInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001D80 RID: 7552 RVA: 0x00051136 File Offset: 0x0004F336
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddTemporaryTeleportInfoNotify Clone()
		{
			return new AddTemporaryTeleportInfoNotify(this);
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06001D81 RID: 7553 RVA: 0x0005113E File Offset: 0x0004F33E
		// (set) Token: 0x06001D82 RID: 7554 RVA: 0x00051146 File Offset: 0x0004F346
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

		// Token: 0x06001D83 RID: 7555 RVA: 0x0005114F File Offset: 0x0004F34F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddTemporaryTeleportInfoNotify);
		}

		// Token: 0x06001D84 RID: 7556 RVA: 0x0005115D File Offset: 0x0004F35D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AddTemporaryTeleportInfoNotify other)
		{
			return other != null && (other == this || (object.Equals(this.TemporaryTeleportInfo, other.TemporaryTeleportInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001D85 RID: 7557 RVA: 0x00051190 File Offset: 0x0004F390
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

		// Token: 0x06001D86 RID: 7558 RVA: 0x000511CC File Offset: 0x0004F3CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001D87 RID: 7559 RVA: 0x000511D9 File Offset: 0x0004F3D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001D88 RID: 7560 RVA: 0x000511E2 File Offset: 0x0004F3E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.temporaryTeleportInfo_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.TemporaryTeleportInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001D89 RID: 7561 RVA: 0x00051214 File Offset: 0x0004F414
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

		// Token: 0x06001D8A RID: 7562 RVA: 0x00051254 File Offset: 0x0004F454
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

		// Token: 0x06001D8B RID: 7563 RVA: 0x000512A8 File Offset: 0x0004F4A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001D8C RID: 7564 RVA: 0x000512B4 File Offset: 0x0004F4B4
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
				if (num != 50U)
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

		// Token: 0x0400231F RID: 8991
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002320 RID: 8992
		public const int TemporaryTeleportInfoFieldNumber = 6;

		// Token: 0x04002321 RID: 8993
		private TemporaryTeleportInfo temporaryTeleportInfo_;
	}
}
