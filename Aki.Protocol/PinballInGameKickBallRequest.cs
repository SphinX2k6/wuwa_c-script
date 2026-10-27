using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D49 RID: 3401
	[NetMessage(EMessageId.PinballInGameKickBallRequest)]
	public sealed class PinballInGameKickBallRequest : IMessage<PinballInGameKickBallRequest>, IMessage, IEquatable<PinballInGameKickBallRequest>, IDeepCloneable<PinballInGameKickBallRequest>, IBufferMessage
	{
		// Token: 0x06012593 RID: 75155 RVA: 0x002AD6AA File Offset: 0x002AB8AA
		[NullableContext(1)]
		public static PinballInGameKickBallRequest Create()
		{
			return new PinballInGameKickBallRequest();
		}

		// Token: 0x17003CCC RID: 15564
		// (get) Token: 0x06012594 RID: 75156 RVA: 0x002AD6B1 File Offset: 0x002AB8B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003CCD RID: 15565
		// (get) Token: 0x06012595 RID: 75157 RVA: 0x002AD6B4 File Offset: 0x002AB8B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballInGameKickBallRequest.Descriptor;
			}
		}

		// Token: 0x06012596 RID: 75158 RVA: 0x002AD6BB File Offset: 0x002AB8BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballInGameKickBallRequest()
		{
		}

		// Token: 0x06012597 RID: 75159 RVA: 0x002AD6C3 File Offset: 0x002AB8C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballInGameKickBallRequest(PinballInGameKickBallRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012598 RID: 75160 RVA: 0x002AD6DC File Offset: 0x002AB8DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballInGameKickBallRequest Clone()
		{
			return new PinballInGameKickBallRequest(this);
		}

		// Token: 0x06012599 RID: 75161 RVA: 0x002AD6E4 File Offset: 0x002AB8E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballInGameKickBallRequest);
		}

		// Token: 0x0601259A RID: 75162 RVA: 0x002AD6F2 File Offset: 0x002AB8F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballInGameKickBallRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601259B RID: 75163 RVA: 0x002AD710 File Offset: 0x002AB910
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

		// Token: 0x0601259C RID: 75164 RVA: 0x002AD736 File Offset: 0x002AB936
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601259D RID: 75165 RVA: 0x002AD743 File Offset: 0x002AB943
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601259E RID: 75166 RVA: 0x002AD74C File Offset: 0x002AB94C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601259F RID: 75167 RVA: 0x002AD764 File Offset: 0x002AB964
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

		// Token: 0x060125A0 RID: 75168 RVA: 0x002AD78A File Offset: 0x002AB98A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballInGameKickBallRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060125A1 RID: 75169 RVA: 0x002AD7A7 File Offset: 0x002AB9A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060125A2 RID: 75170 RVA: 0x002AD7B0 File Offset: 0x002AB9B0
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

		// Token: 0x04007251 RID: 29265
		private UnknownFieldSet _unknownFields;
	}
}
