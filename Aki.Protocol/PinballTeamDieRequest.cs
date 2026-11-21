using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D55 RID: 3413
	[NetMessage(EMessageId.PinballTeamDieRequest)]
	public sealed class PinballTeamDieRequest : IMessage<PinballTeamDieRequest>, IMessage, IEquatable<PinballTeamDieRequest>, IDeepCloneable<PinballTeamDieRequest>, IBufferMessage
	{
		// Token: 0x060126E4 RID: 75492 RVA: 0x002B0F51 File Offset: 0x002AF151
		[NullableContext(1)]
		public static PinballTeamDieRequest Create()
		{
			return new PinballTeamDieRequest();
		}

		// Token: 0x17003D18 RID: 15640
		// (get) Token: 0x060126E5 RID: 75493 RVA: 0x002B0F58 File Offset: 0x002AF158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D19 RID: 15641
		// (get) Token: 0x060126E6 RID: 75494 RVA: 0x002B0F5B File Offset: 0x002AF15B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballTeamDieRequest.Descriptor;
			}
		}

		// Token: 0x060126E7 RID: 75495 RVA: 0x002B0F62 File Offset: 0x002AF162
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballTeamDieRequest()
		{
		}

		// Token: 0x060126E8 RID: 75496 RVA: 0x002B0F6A File Offset: 0x002AF16A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballTeamDieRequest(PinballTeamDieRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060126E9 RID: 75497 RVA: 0x002B0F83 File Offset: 0x002AF183
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballTeamDieRequest Clone()
		{
			return new PinballTeamDieRequest(this);
		}

		// Token: 0x060126EA RID: 75498 RVA: 0x002B0F8B File Offset: 0x002AF18B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballTeamDieRequest);
		}

		// Token: 0x060126EB RID: 75499 RVA: 0x002B0F99 File Offset: 0x002AF199
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballTeamDieRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060126EC RID: 75500 RVA: 0x002B0FB8 File Offset: 0x002AF1B8
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

		// Token: 0x060126ED RID: 75501 RVA: 0x002B0FDE File Offset: 0x002AF1DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060126EE RID: 75502 RVA: 0x002B0FEB File Offset: 0x002AF1EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060126EF RID: 75503 RVA: 0x002B0FF4 File Offset: 0x002AF1F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060126F0 RID: 75504 RVA: 0x002B100C File Offset: 0x002AF20C
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

		// Token: 0x060126F1 RID: 75505 RVA: 0x002B1032 File Offset: 0x002AF232
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballTeamDieRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060126F2 RID: 75506 RVA: 0x002B104F File Offset: 0x002AF24F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060126F3 RID: 75507 RVA: 0x002B1058 File Offset: 0x002AF258
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

		// Token: 0x04007318 RID: 29464
		private UnknownFieldSet _unknownFields;
	}
}
