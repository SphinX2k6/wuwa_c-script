using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B50 RID: 2896
	public sealed class NormalLevel : IMessage<NormalLevel>, IMessage, IEquatable<NormalLevel>, IDeepCloneable<NormalLevel>, IBufferMessage
	{
		// Token: 0x0600FB50 RID: 64336 RVA: 0x00249FF0 File Offset: 0x002481F0
		[NullableContext(1)]
		public static NormalLevel Create()
		{
			return new NormalLevel();
		}

		// Token: 0x17003336 RID: 13110
		// (get) Token: 0x0600FB51 RID: 64337 RVA: 0x00249FF7 File Offset: 0x002481F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003337 RID: 13111
		// (get) Token: 0x0600FB52 RID: 64338 RVA: 0x00249FFA File Offset: 0x002481FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NormalLevel.Descriptor;
			}
		}

		// Token: 0x0600FB53 RID: 64339 RVA: 0x0024A001 File Offset: 0x00248201
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NormalLevel()
		{
		}

		// Token: 0x0600FB54 RID: 64340 RVA: 0x0024A009 File Offset: 0x00248209
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NormalLevel(NormalLevel other) : this()
		{
			this.starByte_ = other.starByte_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FB55 RID: 64341 RVA: 0x0024A02E File Offset: 0x0024822E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NormalLevel Clone()
		{
			return new NormalLevel(this);
		}

		// Token: 0x17003338 RID: 13112
		// (get) Token: 0x0600FB56 RID: 64342 RVA: 0x0024A036 File Offset: 0x00248236
		// (set) Token: 0x0600FB57 RID: 64343 RVA: 0x0024A03E File Offset: 0x0024823E
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

		// Token: 0x0600FB58 RID: 64344 RVA: 0x0024A047 File Offset: 0x00248247
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NormalLevel);
		}

		// Token: 0x0600FB59 RID: 64345 RVA: 0x0024A055 File Offset: 0x00248255
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NormalLevel other)
		{
			return other != null && (other == this || (this.StarByte == other.StarByte && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FB5A RID: 64346 RVA: 0x0024A084 File Offset: 0x00248284
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

		// Token: 0x0600FB5B RID: 64347 RVA: 0x0024A0C3 File Offset: 0x002482C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FB5C RID: 64348 RVA: 0x0024A0D0 File Offset: 0x002482D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FB5D RID: 64349 RVA: 0x0024A0D9 File Offset: 0x002482D9
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

		// Token: 0x0600FB5E RID: 64350 RVA: 0x0024A10C File Offset: 0x0024830C
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

		// Token: 0x0600FB5F RID: 64351 RVA: 0x0024A14A File Offset: 0x0024834A
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

		// Token: 0x0600FB60 RID: 64352 RVA: 0x0024A17B File Offset: 0x0024837B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FB61 RID: 64353 RVA: 0x0024A184 File Offset: 0x00248384
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

		// Token: 0x040064CC RID: 25804
		private UnknownFieldSet _unknownFields;

		// Token: 0x040064CD RID: 25805
		public const int StarByteFieldNumber = 1;

		// Token: 0x040064CE RID: 25806
		private int starByte_;
	}
}
