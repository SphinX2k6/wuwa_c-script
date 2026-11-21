using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A3D RID: 2621
	[NetMessage(EMessageId.MotorFightPlayerDeadRequest)]
	public sealed class MotorFightPlayerDeadRequest : IMessage<MotorFightPlayerDeadRequest>, IMessage, IEquatable<MotorFightPlayerDeadRequest>, IDeepCloneable<MotorFightPlayerDeadRequest>, IBufferMessage
	{
		// Token: 0x0600E51D RID: 58653 RVA: 0x002181ED File Offset: 0x002163ED
		[NullableContext(1)]
		public static MotorFightPlayerDeadRequest Create()
		{
			return new MotorFightPlayerDeadRequest();
		}

		// Token: 0x17002E70 RID: 11888
		// (get) Token: 0x0600E51E RID: 58654 RVA: 0x002181F4 File Offset: 0x002163F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E71 RID: 11889
		// (get) Token: 0x0600E51F RID: 58655 RVA: 0x002181F7 File Offset: 0x002163F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightPlayerDeadRequest.Descriptor;
			}
		}

		// Token: 0x0600E520 RID: 58656 RVA: 0x002181FE File Offset: 0x002163FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightPlayerDeadRequest()
		{
		}

		// Token: 0x0600E521 RID: 58657 RVA: 0x00218206 File Offset: 0x00216406
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightPlayerDeadRequest(MotorFightPlayerDeadRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E522 RID: 58658 RVA: 0x0021821F File Offset: 0x0021641F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightPlayerDeadRequest Clone()
		{
			return new MotorFightPlayerDeadRequest(this);
		}

		// Token: 0x0600E523 RID: 58659 RVA: 0x00218227 File Offset: 0x00216427
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightPlayerDeadRequest);
		}

		// Token: 0x0600E524 RID: 58660 RVA: 0x00218235 File Offset: 0x00216435
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightPlayerDeadRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600E525 RID: 58661 RVA: 0x00218254 File Offset: 0x00216454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E526 RID: 58662 RVA: 0x0021827A File Offset: 0x0021647A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E527 RID: 58663 RVA: 0x00218287 File Offset: 0x00216487
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E528 RID: 58664 RVA: 0x00218290 File Offset: 0x00216490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E529 RID: 58665 RVA: 0x002182A8 File Offset: 0x002164A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E52A RID: 58666 RVA: 0x002182CE File Offset: 0x002164CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightPlayerDeadRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E52B RID: 58667 RVA: 0x002182EB File Offset: 0x002164EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E52C RID: 58668 RVA: 0x002182F4 File Offset: 0x002164F4
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
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005DFE RID: 24062
		private UnknownFieldSet _unknownFields;
	}
}
