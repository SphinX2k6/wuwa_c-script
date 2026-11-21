using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A57 RID: 2647
	[NetMessage(EMessageId.MotorFightSettleRequest)]
	public sealed class MotorFightSettleRequest : IMessage<MotorFightSettleRequest>, IMessage, IEquatable<MotorFightSettleRequest>, IDeepCloneable<MotorFightSettleRequest>, IBufferMessage
	{
		// Token: 0x0600E74C RID: 59212 RVA: 0x0021D355 File Offset: 0x0021B555
		[NullableContext(1)]
		public static MotorFightSettleRequest Create()
		{
			return new MotorFightSettleRequest();
		}

		// Token: 0x17002EED RID: 12013
		// (get) Token: 0x0600E74D RID: 59213 RVA: 0x0021D35C File Offset: 0x0021B55C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002EEE RID: 12014
		// (get) Token: 0x0600E74E RID: 59214 RVA: 0x0021D35F File Offset: 0x0021B55F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightSettleRequest.Descriptor;
			}
		}

		// Token: 0x0600E74F RID: 59215 RVA: 0x0021D366 File Offset: 0x0021B566
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightSettleRequest()
		{
		}

		// Token: 0x0600E750 RID: 59216 RVA: 0x0021D36E File Offset: 0x0021B56E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightSettleRequest(MotorFightSettleRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E751 RID: 59217 RVA: 0x0021D387 File Offset: 0x0021B587
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightSettleRequest Clone()
		{
			return new MotorFightSettleRequest(this);
		}

		// Token: 0x0600E752 RID: 59218 RVA: 0x0021D38F File Offset: 0x0021B58F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightSettleRequest);
		}

		// Token: 0x0600E753 RID: 59219 RVA: 0x0021D39D File Offset: 0x0021B59D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightSettleRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600E754 RID: 59220 RVA: 0x0021D3BC File Offset: 0x0021B5BC
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

		// Token: 0x0600E755 RID: 59221 RVA: 0x0021D3E2 File Offset: 0x0021B5E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E756 RID: 59222 RVA: 0x0021D3EF File Offset: 0x0021B5EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E757 RID: 59223 RVA: 0x0021D3F8 File Offset: 0x0021B5F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E758 RID: 59224 RVA: 0x0021D410 File Offset: 0x0021B610
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

		// Token: 0x0600E759 RID: 59225 RVA: 0x0021D436 File Offset: 0x0021B636
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightSettleRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E75A RID: 59226 RVA: 0x0021D453 File Offset: 0x0021B653
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E75B RID: 59227 RVA: 0x0021D45C File Offset: 0x0021B65C
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

		// Token: 0x04005EB2 RID: 24242
		private UnknownFieldSet _unknownFields;
	}
}
