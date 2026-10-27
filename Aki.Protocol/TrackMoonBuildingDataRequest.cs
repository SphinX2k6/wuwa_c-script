using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013DF RID: 5087
	[NetMessage(EMessageId.TrackMoonBuildingDataRequest)]
	public sealed class TrackMoonBuildingDataRequest : IMessage<TrackMoonBuildingDataRequest>, IMessage, IEquatable<TrackMoonBuildingDataRequest>, IDeepCloneable<TrackMoonBuildingDataRequest>, IBufferMessage
	{
		// Token: 0x0601AF81 RID: 110465 RVA: 0x003E845D File Offset: 0x003E665D
		[NullableContext(1)]
		public static TrackMoonBuildingDataRequest Create()
		{
			return new TrackMoonBuildingDataRequest();
		}

		// Token: 0x17005AEB RID: 23275
		// (get) Token: 0x0601AF82 RID: 110466 RVA: 0x003E8464 File Offset: 0x003E6664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005AEC RID: 23276
		// (get) Token: 0x0601AF83 RID: 110467 RVA: 0x003E8467 File Offset: 0x003E6667
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrackMoonBuildingDataRequest.Descriptor;
			}
		}

		// Token: 0x0601AF84 RID: 110468 RVA: 0x003E846E File Offset: 0x003E666E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonBuildingDataRequest()
		{
		}

		// Token: 0x0601AF85 RID: 110469 RVA: 0x003E8476 File Offset: 0x003E6676
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonBuildingDataRequest(TrackMoonBuildingDataRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AF86 RID: 110470 RVA: 0x003E848F File Offset: 0x003E668F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonBuildingDataRequest Clone()
		{
			return new TrackMoonBuildingDataRequest(this);
		}

		// Token: 0x0601AF87 RID: 110471 RVA: 0x003E8497 File Offset: 0x003E6697
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrackMoonBuildingDataRequest);
		}

		// Token: 0x0601AF88 RID: 110472 RVA: 0x003E84A5 File Offset: 0x003E66A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrackMoonBuildingDataRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601AF89 RID: 110473 RVA: 0x003E84C4 File Offset: 0x003E66C4
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

		// Token: 0x0601AF8A RID: 110474 RVA: 0x003E84EA File Offset: 0x003E66EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AF8B RID: 110475 RVA: 0x003E84F7 File Offset: 0x003E66F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AF8C RID: 110476 RVA: 0x003E8500 File Offset: 0x003E6700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AF8D RID: 110477 RVA: 0x003E8518 File Offset: 0x003E6718
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

		// Token: 0x0601AF8E RID: 110478 RVA: 0x003E853E File Offset: 0x003E673E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrackMoonBuildingDataRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601AF8F RID: 110479 RVA: 0x003E855B File Offset: 0x003E675B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AF90 RID: 110480 RVA: 0x003E8564 File Offset: 0x003E6764
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

		// Token: 0x04009C3E RID: 39998
		private UnknownFieldSet _unknownFields;
	}
}
