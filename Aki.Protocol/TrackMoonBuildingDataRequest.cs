using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001452 RID: 5202
	[NetMessage(EMessageId.TrackMoonBuildingDataRequest)]
	public sealed class TrackMoonBuildingDataRequest : IMessage<TrackMoonBuildingDataRequest>, IMessage, IEquatable<TrackMoonBuildingDataRequest>, IDeepCloneable<TrackMoonBuildingDataRequest>, IBufferMessage
	{
		// Token: 0x0601BA0C RID: 113164 RVA: 0x00403729 File Offset: 0x00401929
		[NullableContext(1)]
		public static TrackMoonBuildingDataRequest Create()
		{
			return new TrackMoonBuildingDataRequest();
		}

		// Token: 0x17005D80 RID: 23936
		// (get) Token: 0x0601BA0D RID: 113165 RVA: 0x00403730 File Offset: 0x00401930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D81 RID: 23937
		// (get) Token: 0x0601BA0E RID: 113166 RVA: 0x00403733 File Offset: 0x00401933
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrackMoonBuildingDataRequest.Descriptor;
			}
		}

		// Token: 0x0601BA0F RID: 113167 RVA: 0x0040373A File Offset: 0x0040193A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonBuildingDataRequest()
		{
		}

		// Token: 0x0601BA10 RID: 113168 RVA: 0x00403742 File Offset: 0x00401942
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonBuildingDataRequest(TrackMoonBuildingDataRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BA11 RID: 113169 RVA: 0x0040375B File Offset: 0x0040195B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonBuildingDataRequest Clone()
		{
			return new TrackMoonBuildingDataRequest(this);
		}

		// Token: 0x0601BA12 RID: 113170 RVA: 0x00403763 File Offset: 0x00401963
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrackMoonBuildingDataRequest);
		}

		// Token: 0x0601BA13 RID: 113171 RVA: 0x00403771 File Offset: 0x00401971
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrackMoonBuildingDataRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601BA14 RID: 113172 RVA: 0x00403790 File Offset: 0x00401990
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

		// Token: 0x0601BA15 RID: 113173 RVA: 0x004037B6 File Offset: 0x004019B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BA16 RID: 113174 RVA: 0x004037C3 File Offset: 0x004019C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BA17 RID: 113175 RVA: 0x004037CC File Offset: 0x004019CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BA18 RID: 113176 RVA: 0x004037E4 File Offset: 0x004019E4
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

		// Token: 0x0601BA19 RID: 113177 RVA: 0x0040380A File Offset: 0x00401A0A
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

		// Token: 0x0601BA1A RID: 113178 RVA: 0x00403827 File Offset: 0x00401A27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BA1B RID: 113179 RVA: 0x00403830 File Offset: 0x00401A30
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

		// Token: 0x0400A085 RID: 41093
		private UnknownFieldSet _unknownFields;
	}
}
