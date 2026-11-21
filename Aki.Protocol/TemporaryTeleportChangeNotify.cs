using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013BD RID: 5053
	[NetMessage(EMessageId.TemporaryTeleportChangeNotify)]
	public sealed class TemporaryTeleportChangeNotify : IMessage<TemporaryTeleportChangeNotify>, IMessage, IEquatable<TemporaryTeleportChangeNotify>, IDeepCloneable<TemporaryTeleportChangeNotify>, IBufferMessage
	{
		// Token: 0x0601AE47 RID: 110151 RVA: 0x003EAAD5 File Offset: 0x003E8CD5
		[NullableContext(1)]
		public static TemporaryTeleportChangeNotify Create()
		{
			return new TemporaryTeleportChangeNotify();
		}

		// Token: 0x17005B13 RID: 23315
		// (get) Token: 0x0601AE48 RID: 110152 RVA: 0x003EAADC File Offset: 0x003E8CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005B14 RID: 23316
		// (get) Token: 0x0601AE49 RID: 110153 RVA: 0x003EAADF File Offset: 0x003E8CDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TemporaryTeleportChangeNotify.Descriptor;
			}
		}

		// Token: 0x0601AE4A RID: 110154 RVA: 0x003EAAE6 File Offset: 0x003E8CE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TemporaryTeleportChangeNotify()
		{
		}

		// Token: 0x0601AE4B RID: 110155 RVA: 0x003EAAEE File Offset: 0x003E8CEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TemporaryTeleportChangeNotify(TemporaryTeleportChangeNotify other) : this()
		{
			this.temporaryTeleportInfo_ = ((other.temporaryTeleportInfo_ != null) ? other.temporaryTeleportInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AE4C RID: 110156 RVA: 0x003EAB23 File Offset: 0x003E8D23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TemporaryTeleportChangeNotify Clone()
		{
			return new TemporaryTeleportChangeNotify(this);
		}

		// Token: 0x17005B15 RID: 23317
		// (get) Token: 0x0601AE4D RID: 110157 RVA: 0x003EAB2B File Offset: 0x003E8D2B
		// (set) Token: 0x0601AE4E RID: 110158 RVA: 0x003EAB33 File Offset: 0x003E8D33
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

		// Token: 0x0601AE4F RID: 110159 RVA: 0x003EAB3C File Offset: 0x003E8D3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TemporaryTeleportChangeNotify);
		}

		// Token: 0x0601AE50 RID: 110160 RVA: 0x003EAB4A File Offset: 0x003E8D4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TemporaryTeleportChangeNotify other)
		{
			return other != null && (other == this || (object.Equals(this.TemporaryTeleportInfo, other.TemporaryTeleportInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AE51 RID: 110161 RVA: 0x003EAB80 File Offset: 0x003E8D80
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

		// Token: 0x0601AE52 RID: 110162 RVA: 0x003EABBC File Offset: 0x003E8DBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AE53 RID: 110163 RVA: 0x003EABC9 File Offset: 0x003E8DC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AE54 RID: 110164 RVA: 0x003EABD2 File Offset: 0x003E8DD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.temporaryTeleportInfo_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.TemporaryTeleportInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AE55 RID: 110165 RVA: 0x003EAC04 File Offset: 0x003E8E04
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

		// Token: 0x0601AE56 RID: 110166 RVA: 0x003EAC44 File Offset: 0x003E8E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TemporaryTeleportChangeNotify other)
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

		// Token: 0x0601AE57 RID: 110167 RVA: 0x003EAC98 File Offset: 0x003E8E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AE58 RID: 110168 RVA: 0x003EACA4 File Offset: 0x003E8EA4
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
				if (num != 106U)
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

		// Token: 0x04009D4C RID: 40268
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009D4D RID: 40269
		public const int TemporaryTeleportInfoFieldNumber = 13;

		// Token: 0x04009D4E RID: 40270
		private TemporaryTeleportInfo temporaryTeleportInfo_;
	}
}
