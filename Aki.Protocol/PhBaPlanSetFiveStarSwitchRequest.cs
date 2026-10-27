using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D1D RID: 3357
	[NetMessage(EMessageId.PhBaPlanSetFiveStarSwitchRequest)]
	public sealed class PhBaPlanSetFiveStarSwitchRequest : IMessage<PhBaPlanSetFiveStarSwitchRequest>, IMessage, IEquatable<PhBaPlanSetFiveStarSwitchRequest>, IDeepCloneable<PhBaPlanSetFiveStarSwitchRequest>, IBufferMessage
	{
		// Token: 0x0601221D RID: 74269 RVA: 0x002A6237 File Offset: 0x002A4437
		[NullableContext(1)]
		public static PhBaPlanSetFiveStarSwitchRequest Create()
		{
			return new PhBaPlanSetFiveStarSwitchRequest();
		}

		// Token: 0x17003C14 RID: 15380
		// (get) Token: 0x0601221E RID: 74270 RVA: 0x002A623E File Offset: 0x002A443E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C15 RID: 15381
		// (get) Token: 0x0601221F RID: 74271 RVA: 0x002A6241 File Offset: 0x002A4441
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhBaPlanSetFiveStarSwitchRequest.Descriptor;
			}
		}

		// Token: 0x06012220 RID: 74272 RVA: 0x002A6248 File Offset: 0x002A4448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanSetFiveStarSwitchRequest()
		{
		}

		// Token: 0x06012221 RID: 74273 RVA: 0x002A6250 File Offset: 0x002A4450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanSetFiveStarSwitchRequest(PhBaPlanSetFiveStarSwitchRequest other) : this()
		{
			this.open_ = other.open_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012222 RID: 74274 RVA: 0x002A6275 File Offset: 0x002A4475
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanSetFiveStarSwitchRequest Clone()
		{
			return new PhBaPlanSetFiveStarSwitchRequest(this);
		}

		// Token: 0x17003C16 RID: 15382
		// (get) Token: 0x06012223 RID: 74275 RVA: 0x002A627D File Offset: 0x002A447D
		// (set) Token: 0x06012224 RID: 74276 RVA: 0x002A6285 File Offset: 0x002A4485
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Open
		{
			get
			{
				return this.open_;
			}
			set
			{
				this.open_ = value;
			}
		}

		// Token: 0x06012225 RID: 74277 RVA: 0x002A628E File Offset: 0x002A448E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhBaPlanSetFiveStarSwitchRequest);
		}

		// Token: 0x06012226 RID: 74278 RVA: 0x002A629C File Offset: 0x002A449C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhBaPlanSetFiveStarSwitchRequest other)
		{
			return other != null && (other == this || (this.Open == other.Open && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012227 RID: 74279 RVA: 0x002A62CC File Offset: 0x002A44CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Open)
			{
				num ^= this.Open.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012228 RID: 74280 RVA: 0x002A630B File Offset: 0x002A450B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012229 RID: 74281 RVA: 0x002A6318 File Offset: 0x002A4518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601222A RID: 74282 RVA: 0x002A6321 File Offset: 0x002A4521
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Open)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.Open);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601222B RID: 74283 RVA: 0x002A6354 File Offset: 0x002A4554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Open)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601222C RID: 74284 RVA: 0x002A6386 File Offset: 0x002A4586
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhBaPlanSetFiveStarSwitchRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Open)
			{
				this.Open = other.Open;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601222D RID: 74285 RVA: 0x002A63B7 File Offset: 0x002A45B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601222E RID: 74286 RVA: 0x002A63C0 File Offset: 0x002A45C0
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
					this.Open = input.ReadBool();
				}
			}
		}

		// Token: 0x04007158 RID: 29016
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007159 RID: 29017
		public const int OpenFieldNumber = 11;

		// Token: 0x0400715A RID: 29018
		private bool open_;
	}
}
