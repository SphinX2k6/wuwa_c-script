using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000990 RID: 2448
	[NetMessage(EMessageId.MapTravelLevelUpRequest)]
	public sealed class MapTravelLevelUpRequest : IMessage<MapTravelLevelUpRequest>, IMessage, IEquatable<MapTravelLevelUpRequest>, IDeepCloneable<MapTravelLevelUpRequest>, IBufferMessage
	{
		// Token: 0x0600D765 RID: 55141 RVA: 0x001FAFCA File Offset: 0x001F91CA
		[NullableContext(1)]
		public static MapTravelLevelUpRequest Create()
		{
			return new MapTravelLevelUpRequest();
		}

		// Token: 0x17002B9A RID: 11162
		// (get) Token: 0x0600D766 RID: 55142 RVA: 0x001FAFD1 File Offset: 0x001F91D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B9B RID: 11163
		// (get) Token: 0x0600D767 RID: 55143 RVA: 0x001FAFD4 File Offset: 0x001F91D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapTravelLevelUpRequest.Descriptor;
			}
		}

		// Token: 0x0600D768 RID: 55144 RVA: 0x001FAFDB File Offset: 0x001F91DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTravelLevelUpRequest()
		{
		}

		// Token: 0x0600D769 RID: 55145 RVA: 0x001FAFE3 File Offset: 0x001F91E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTravelLevelUpRequest(MapTravelLevelUpRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D76A RID: 55146 RVA: 0x001FAFFC File Offset: 0x001F91FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTravelLevelUpRequest Clone()
		{
			return new MapTravelLevelUpRequest(this);
		}

		// Token: 0x0600D76B RID: 55147 RVA: 0x001FB004 File Offset: 0x001F9204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapTravelLevelUpRequest);
		}

		// Token: 0x0600D76C RID: 55148 RVA: 0x001FB012 File Offset: 0x001F9212
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapTravelLevelUpRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600D76D RID: 55149 RVA: 0x001FB030 File Offset: 0x001F9230
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

		// Token: 0x0600D76E RID: 55150 RVA: 0x001FB056 File Offset: 0x001F9256
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D76F RID: 55151 RVA: 0x001FB063 File Offset: 0x001F9263
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D770 RID: 55152 RVA: 0x001FB06C File Offset: 0x001F926C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D771 RID: 55153 RVA: 0x001FB084 File Offset: 0x001F9284
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

		// Token: 0x0600D772 RID: 55154 RVA: 0x001FB0AA File Offset: 0x001F92AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MapTravelLevelUpRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D773 RID: 55155 RVA: 0x001FB0C7 File Offset: 0x001F92C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D774 RID: 55156 RVA: 0x001FB0D0 File Offset: 0x001F92D0
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

		// Token: 0x04005A3D RID: 23101
		private UnknownFieldSet _unknownFields;
	}
}
