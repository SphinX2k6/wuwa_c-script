using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001241 RID: 4673
	[NetMessage(EMessageId.ShortMessageReadRequest)]
	public sealed class ShortMessageReadRequest : IMessage<ShortMessageReadRequest>, IMessage, IEquatable<ShortMessageReadRequest>, IDeepCloneable<ShortMessageReadRequest>, IBufferMessage
	{
		// Token: 0x06018F54 RID: 102228 RVA: 0x003A3AD2 File Offset: 0x003A1CD2
		[NullableContext(1)]
		public static ShortMessageReadRequest Create()
		{
			return new ShortMessageReadRequest();
		}

		// Token: 0x1700545B RID: 21595
		// (get) Token: 0x06018F55 RID: 102229 RVA: 0x003A3AD9 File Offset: 0x003A1CD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700545C RID: 21596
		// (get) Token: 0x06018F56 RID: 102230 RVA: 0x003A3ADC File Offset: 0x003A1CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShortMessageReadRequest.Descriptor;
			}
		}

		// Token: 0x06018F57 RID: 102231 RVA: 0x003A3AE3 File Offset: 0x003A1CE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageReadRequest()
		{
		}

		// Token: 0x06018F58 RID: 102232 RVA: 0x003A3AEB File Offset: 0x003A1CEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageReadRequest(ShortMessageReadRequest other) : this()
		{
			this.configId_ = other.configId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018F59 RID: 102233 RVA: 0x003A3B10 File Offset: 0x003A1D10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageReadRequest Clone()
		{
			return new ShortMessageReadRequest(this);
		}

		// Token: 0x1700545D RID: 21597
		// (get) Token: 0x06018F5A RID: 102234 RVA: 0x003A3B18 File Offset: 0x003A1D18
		// (set) Token: 0x06018F5B RID: 102235 RVA: 0x003A3B20 File Offset: 0x003A1D20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x06018F5C RID: 102236 RVA: 0x003A3B29 File Offset: 0x003A1D29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShortMessageReadRequest);
		}

		// Token: 0x06018F5D RID: 102237 RVA: 0x003A3B37 File Offset: 0x003A1D37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShortMessageReadRequest other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018F5E RID: 102238 RVA: 0x003A3B68 File Offset: 0x003A1D68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018F5F RID: 102239 RVA: 0x003A3BA7 File Offset: 0x003A1DA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018F60 RID: 102240 RVA: 0x003A3BB4 File Offset: 0x003A1DB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018F61 RID: 102241 RVA: 0x003A3BBD File Offset: 0x003A1DBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.ConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018F62 RID: 102242 RVA: 0x003A3BF0 File Offset: 0x003A1DF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018F63 RID: 102243 RVA: 0x003A3C2E File Offset: 0x003A1E2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShortMessageReadRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018F64 RID: 102244 RVA: 0x003A3C5F File Offset: 0x003A1E5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018F65 RID: 102245 RVA: 0x003A3C68 File Offset: 0x003A1E68
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ConfigId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009413 RID: 37907
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009414 RID: 37908
		public const int ConfigIdFieldNumber = 9;

		// Token: 0x04009415 RID: 37909
		private int configId_;
	}
}
