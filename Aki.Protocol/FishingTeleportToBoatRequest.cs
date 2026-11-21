using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200057A RID: 1402
	[NetMessage(EMessageId.FishingTeleportToBoatRequest)]
	public sealed class FishingTeleportToBoatRequest : IMessage<FishingTeleportToBoatRequest>, IMessage, IEquatable<FishingTeleportToBoatRequest>, IDeepCloneable<FishingTeleportToBoatRequest>, IBufferMessage
	{
		// Token: 0x06008280 RID: 33408 RVA: 0x0013AC97 File Offset: 0x00138E97
		[NullableContext(1)]
		public static FishingTeleportToBoatRequest Create()
		{
			return new FishingTeleportToBoatRequest();
		}

		// Token: 0x17001966 RID: 6502
		// (get) Token: 0x06008281 RID: 33409 RVA: 0x0013AC9E File Offset: 0x00138E9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001967 RID: 6503
		// (get) Token: 0x06008282 RID: 33410 RVA: 0x0013ACA1 File Offset: 0x00138EA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingTeleportToBoatRequest.Descriptor;
			}
		}

		// Token: 0x06008283 RID: 33411 RVA: 0x0013ACA8 File Offset: 0x00138EA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingTeleportToBoatRequest()
		{
		}

		// Token: 0x06008284 RID: 33412 RVA: 0x0013ACB0 File Offset: 0x00138EB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingTeleportToBoatRequest(FishingTeleportToBoatRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008285 RID: 33413 RVA: 0x0013ACC9 File Offset: 0x00138EC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingTeleportToBoatRequest Clone()
		{
			return new FishingTeleportToBoatRequest(this);
		}

		// Token: 0x06008286 RID: 33414 RVA: 0x0013ACD1 File Offset: 0x00138ED1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingTeleportToBoatRequest);
		}

		// Token: 0x06008287 RID: 33415 RVA: 0x0013ACDF File Offset: 0x00138EDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingTeleportToBoatRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06008288 RID: 33416 RVA: 0x0013AD00 File Offset: 0x00138F00
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

		// Token: 0x06008289 RID: 33417 RVA: 0x0013AD26 File Offset: 0x00138F26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600828A RID: 33418 RVA: 0x0013AD33 File Offset: 0x00138F33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600828B RID: 33419 RVA: 0x0013AD3C File Offset: 0x00138F3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600828C RID: 33420 RVA: 0x0013AD54 File Offset: 0x00138F54
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

		// Token: 0x0600828D RID: 33421 RVA: 0x0013AD7A File Offset: 0x00138F7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingTeleportToBoatRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600828E RID: 33422 RVA: 0x0013AD97 File Offset: 0x00138F97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600828F RID: 33423 RVA: 0x0013ADA0 File Offset: 0x00138FA0
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

		// Token: 0x04004189 RID: 16777
		private UnknownFieldSet _unknownFields;
	}
}
