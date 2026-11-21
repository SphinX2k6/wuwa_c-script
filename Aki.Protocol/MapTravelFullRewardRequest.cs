using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200098D RID: 2445
	[NetMessage(EMessageId.MapTravelFullRewardRequest)]
	public sealed class MapTravelFullRewardRequest : IMessage<MapTravelFullRewardRequest>, IMessage, IEquatable<MapTravelFullRewardRequest>, IDeepCloneable<MapTravelFullRewardRequest>, IBufferMessage
	{
		// Token: 0x0600D725 RID: 55077 RVA: 0x001FA719 File Offset: 0x001F8919
		[NullableContext(1)]
		public static MapTravelFullRewardRequest Create()
		{
			return new MapTravelFullRewardRequest();
		}

		// Token: 0x17002B8C RID: 11148
		// (get) Token: 0x0600D726 RID: 55078 RVA: 0x001FA720 File Offset: 0x001F8920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B8D RID: 11149
		// (get) Token: 0x0600D727 RID: 55079 RVA: 0x001FA723 File Offset: 0x001F8923
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapTravelFullRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600D728 RID: 55080 RVA: 0x001FA72A File Offset: 0x001F892A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTravelFullRewardRequest()
		{
		}

		// Token: 0x0600D729 RID: 55081 RVA: 0x001FA732 File Offset: 0x001F8932
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTravelFullRewardRequest(MapTravelFullRewardRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D72A RID: 55082 RVA: 0x001FA74B File Offset: 0x001F894B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTravelFullRewardRequest Clone()
		{
			return new MapTravelFullRewardRequest(this);
		}

		// Token: 0x0600D72B RID: 55083 RVA: 0x001FA753 File Offset: 0x001F8953
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapTravelFullRewardRequest);
		}

		// Token: 0x0600D72C RID: 55084 RVA: 0x001FA761 File Offset: 0x001F8961
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapTravelFullRewardRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600D72D RID: 55085 RVA: 0x001FA780 File Offset: 0x001F8980
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

		// Token: 0x0600D72E RID: 55086 RVA: 0x001FA7A6 File Offset: 0x001F89A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D72F RID: 55087 RVA: 0x001FA7B3 File Offset: 0x001F89B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D730 RID: 55088 RVA: 0x001FA7BC File Offset: 0x001F89BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D731 RID: 55089 RVA: 0x001FA7D4 File Offset: 0x001F89D4
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

		// Token: 0x0600D732 RID: 55090 RVA: 0x001FA7FA File Offset: 0x001F89FA
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

		// Token: 0x0600D733 RID: 55091 RVA: 0x001FA817 File Offset: 0x001F8A17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D734 RID: 55092 RVA: 0x001FA820 File Offset: 0x001F8A20
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

		// Token: 0x04005A32 RID: 23090
		private UnknownFieldSet _unknownFields;
	}
}
