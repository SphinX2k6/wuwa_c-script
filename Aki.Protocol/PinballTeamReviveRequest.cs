using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D57 RID: 3415
	[NetMessage(EMessageId.PinballTeamReviveRequest)]
	public sealed class PinballTeamReviveRequest : IMessage<PinballTeamReviveRequest>, IMessage, IEquatable<PinballTeamReviveRequest>, IDeepCloneable<PinballTeamReviveRequest>, IBufferMessage
	{
		// Token: 0x06012706 RID: 75526 RVA: 0x002B126D File Offset: 0x002AF46D
		[NullableContext(1)]
		public static PinballTeamReviveRequest Create()
		{
			return new PinballTeamReviveRequest();
		}

		// Token: 0x17003D1D RID: 15645
		// (get) Token: 0x06012707 RID: 75527 RVA: 0x002B1274 File Offset: 0x002AF474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D1E RID: 15646
		// (get) Token: 0x06012708 RID: 75528 RVA: 0x002B1277 File Offset: 0x002AF477
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballTeamReviveRequest.Descriptor;
			}
		}

		// Token: 0x06012709 RID: 75529 RVA: 0x002B127E File Offset: 0x002AF47E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballTeamReviveRequest()
		{
		}

		// Token: 0x0601270A RID: 75530 RVA: 0x002B1286 File Offset: 0x002AF486
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballTeamReviveRequest(PinballTeamReviveRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601270B RID: 75531 RVA: 0x002B129F File Offset: 0x002AF49F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballTeamReviveRequest Clone()
		{
			return new PinballTeamReviveRequest(this);
		}

		// Token: 0x0601270C RID: 75532 RVA: 0x002B12A7 File Offset: 0x002AF4A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballTeamReviveRequest);
		}

		// Token: 0x0601270D RID: 75533 RVA: 0x002B12B5 File Offset: 0x002AF4B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballTeamReviveRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601270E RID: 75534 RVA: 0x002B12D4 File Offset: 0x002AF4D4
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

		// Token: 0x0601270F RID: 75535 RVA: 0x002B12FA File Offset: 0x002AF4FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012710 RID: 75536 RVA: 0x002B1307 File Offset: 0x002AF507
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012711 RID: 75537 RVA: 0x002B1310 File Offset: 0x002AF510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012712 RID: 75538 RVA: 0x002B1328 File Offset: 0x002AF528
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

		// Token: 0x06012713 RID: 75539 RVA: 0x002B134E File Offset: 0x002AF54E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballTeamReviveRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012714 RID: 75540 RVA: 0x002B136B File Offset: 0x002AF56B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012715 RID: 75541 RVA: 0x002B1374 File Offset: 0x002AF574
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

		// Token: 0x0400731C RID: 29468
		private UnknownFieldSet _unknownFields;
	}
}
