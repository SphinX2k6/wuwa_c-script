using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200058F RID: 1423
	[NetMessage(EMessageId.FishingTeleportToBoatRequest)]
	public sealed class FishingTeleportToBoatRequest : IMessage<FishingTeleportToBoatRequest>, IMessage, IEquatable<FishingTeleportToBoatRequest>, IDeepCloneable<FishingTeleportToBoatRequest>, IBufferMessage
	{
		// Token: 0x060083E8 RID: 33768 RVA: 0x0013D8A3 File Offset: 0x0013BAA3
		[NullableContext(1)]
		public static FishingTeleportToBoatRequest Create()
		{
			return new FishingTeleportToBoatRequest();
		}

		// Token: 0x170019B3 RID: 6579
		// (get) Token: 0x060083E9 RID: 33769 RVA: 0x0013D8AA File Offset: 0x0013BAAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170019B4 RID: 6580
		// (get) Token: 0x060083EA RID: 33770 RVA: 0x0013D8AD File Offset: 0x0013BAAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingTeleportToBoatRequest.Descriptor;
			}
		}

		// Token: 0x060083EB RID: 33771 RVA: 0x0013D8B4 File Offset: 0x0013BAB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingTeleportToBoatRequest()
		{
		}

		// Token: 0x060083EC RID: 33772 RVA: 0x0013D8BC File Offset: 0x0013BABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingTeleportToBoatRequest(FishingTeleportToBoatRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060083ED RID: 33773 RVA: 0x0013D8D5 File Offset: 0x0013BAD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingTeleportToBoatRequest Clone()
		{
			return new FishingTeleportToBoatRequest(this);
		}

		// Token: 0x060083EE RID: 33774 RVA: 0x0013D8DD File Offset: 0x0013BADD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingTeleportToBoatRequest);
		}

		// Token: 0x060083EF RID: 33775 RVA: 0x0013D8EB File Offset: 0x0013BAEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingTeleportToBoatRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060083F0 RID: 33776 RVA: 0x0013D90C File Offset: 0x0013BB0C
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

		// Token: 0x060083F1 RID: 33777 RVA: 0x0013D932 File Offset: 0x0013BB32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060083F2 RID: 33778 RVA: 0x0013D93F File Offset: 0x0013BB3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060083F3 RID: 33779 RVA: 0x0013D948 File Offset: 0x0013BB48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060083F4 RID: 33780 RVA: 0x0013D960 File Offset: 0x0013BB60
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

		// Token: 0x060083F5 RID: 33781 RVA: 0x0013D986 File Offset: 0x0013BB86
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

		// Token: 0x060083F6 RID: 33782 RVA: 0x0013D9A3 File Offset: 0x0013BBA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060083F7 RID: 33783 RVA: 0x0013D9AC File Offset: 0x0013BBAC
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

		// Token: 0x04004193 RID: 16787
		private UnknownFieldSet _unknownFields;
	}
}
