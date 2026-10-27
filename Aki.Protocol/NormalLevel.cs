using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B61 RID: 2913
	public sealed class NormalLevel : IMessage<NormalLevel>, IMessage, IEquatable<NormalLevel>, IDeepCloneable<NormalLevel>, IBufferMessage
	{
		// Token: 0x0600FC6A RID: 64618 RVA: 0x0024C204 File Offset: 0x0024A404
		[NullableContext(1)]
		public static NormalLevel Create()
		{
			return new NormalLevel();
		}

		// Token: 0x17003374 RID: 13172
		// (get) Token: 0x0600FC6B RID: 64619 RVA: 0x0024C20B File Offset: 0x0024A40B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003375 RID: 13173
		// (get) Token: 0x0600FC6C RID: 64620 RVA: 0x0024C20E File Offset: 0x0024A40E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NormalLevel.Descriptor;
			}
		}

		// Token: 0x0600FC6D RID: 64621 RVA: 0x0024C215 File Offset: 0x0024A415
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NormalLevel()
		{
		}

		// Token: 0x0600FC6E RID: 64622 RVA: 0x0024C21D File Offset: 0x0024A41D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NormalLevel(NormalLevel other) : this()
		{
			this.starByte_ = other.starByte_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FC6F RID: 64623 RVA: 0x0024C242 File Offset: 0x0024A442
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NormalLevel Clone()
		{
			return new NormalLevel(this);
		}

		// Token: 0x17003376 RID: 13174
		// (get) Token: 0x0600FC70 RID: 64624 RVA: 0x0024C24A File Offset: 0x0024A44A
		// (set) Token: 0x0600FC71 RID: 64625 RVA: 0x0024C252 File Offset: 0x0024A452
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StarByte
		{
			get
			{
				return this.starByte_;
			}
			set
			{
				this.starByte_ = value;
			}
		}

		// Token: 0x0600FC72 RID: 64626 RVA: 0x0024C25B File Offset: 0x0024A45B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NormalLevel);
		}

		// Token: 0x0600FC73 RID: 64627 RVA: 0x0024C269 File Offset: 0x0024A469
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NormalLevel other)
		{
			return other != null && (other == this || (this.StarByte == other.StarByte && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FC74 RID: 64628 RVA: 0x0024C298 File Offset: 0x0024A498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.StarByte != 0)
			{
				num ^= this.StarByte.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FC75 RID: 64629 RVA: 0x0024C2D7 File Offset: 0x0024A4D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FC76 RID: 64630 RVA: 0x0024C2E4 File Offset: 0x0024A4E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FC77 RID: 64631 RVA: 0x0024C2ED File Offset: 0x0024A4ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.StarByte != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.StarByte);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FC78 RID: 64632 RVA: 0x0024C320 File Offset: 0x0024A520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.StarByte != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StarByte);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FC79 RID: 64633 RVA: 0x0024C35E File Offset: 0x0024A55E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NormalLevel other)
		{
			if (other == null)
			{
				return;
			}
			if (other.StarByte != 0)
			{
				this.StarByte = other.StarByte;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FC7A RID: 64634 RVA: 0x0024C38F File Offset: 0x0024A58F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FC7B RID: 64635 RVA: 0x0024C398 File Offset: 0x0024A598
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
					this.StarByte = input.ReadInt32();
				}
			}
		}

		// Token: 0x040064C3 RID: 25795
		private UnknownFieldSet _unknownFields;

		// Token: 0x040064C4 RID: 25796
		public const int StarByteFieldNumber = 1;

		// Token: 0x040064C5 RID: 25797
		private int starByte_;
	}
}
