using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200099E RID: 2462
	[NetMessage(EMessageId.MapTravelFullRewardRequest)]
	public sealed class MapTravelFullRewardRequest : IMessage<MapTravelFullRewardRequest>, IMessage, IEquatable<MapTravelFullRewardRequest>, IDeepCloneable<MapTravelFullRewardRequest>, IBufferMessage
	{
		// Token: 0x0600D83F RID: 55359 RVA: 0x001FC909 File Offset: 0x001FAB09
		[NullableContext(1)]
		public static MapTravelFullRewardRequest Create()
		{
			return new MapTravelFullRewardRequest();
		}

		// Token: 0x17002BCA RID: 11210
		// (get) Token: 0x0600D840 RID: 55360 RVA: 0x001FC910 File Offset: 0x001FAB10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002BCB RID: 11211
		// (get) Token: 0x0600D841 RID: 55361 RVA: 0x001FC913 File Offset: 0x001FAB13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapTravelFullRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600D842 RID: 55362 RVA: 0x001FC91A File Offset: 0x001FAB1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTravelFullRewardRequest()
		{
		}

		// Token: 0x0600D843 RID: 55363 RVA: 0x001FC922 File Offset: 0x001FAB22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTravelFullRewardRequest(MapTravelFullRewardRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D844 RID: 55364 RVA: 0x001FC93B File Offset: 0x001FAB3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTravelFullRewardRequest Clone()
		{
			return new MapTravelFullRewardRequest(this);
		}

		// Token: 0x0600D845 RID: 55365 RVA: 0x001FC943 File Offset: 0x001FAB43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapTravelFullRewardRequest);
		}

		// Token: 0x0600D846 RID: 55366 RVA: 0x001FC951 File Offset: 0x001FAB51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapTravelFullRewardRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600D847 RID: 55367 RVA: 0x001FC970 File Offset: 0x001FAB70
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

		// Token: 0x0600D848 RID: 55368 RVA: 0x001FC996 File Offset: 0x001FAB96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D849 RID: 55369 RVA: 0x001FC9A3 File Offset: 0x001FABA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D84A RID: 55370 RVA: 0x001FC9AC File Offset: 0x001FABAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D84B RID: 55371 RVA: 0x001FC9C4 File Offset: 0x001FABC4
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

		// Token: 0x0600D84C RID: 55372 RVA: 0x001FC9EA File Offset: 0x001FABEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MapTravelFullRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D84D RID: 55373 RVA: 0x001FCA07 File Offset: 0x001FAC07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D84E RID: 55374 RVA: 0x001FCA10 File Offset: 0x001FAC10
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

		// Token: 0x04005A29 RID: 23081
		private UnknownFieldSet _unknownFields;
	}
}
