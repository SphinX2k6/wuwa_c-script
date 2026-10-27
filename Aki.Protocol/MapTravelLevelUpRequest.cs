using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009A1 RID: 2465
	[NetMessage(EMessageId.MapTravelLevelUpRequest)]
	public sealed class MapTravelLevelUpRequest : IMessage<MapTravelLevelUpRequest>, IMessage, IEquatable<MapTravelLevelUpRequest>, IDeepCloneable<MapTravelLevelUpRequest>, IBufferMessage
	{
		// Token: 0x0600D87F RID: 55423 RVA: 0x001FD1BE File Offset: 0x001FB3BE
		[NullableContext(1)]
		public static MapTravelLevelUpRequest Create()
		{
			return new MapTravelLevelUpRequest();
		}

		// Token: 0x17002BD8 RID: 11224
		// (get) Token: 0x0600D880 RID: 55424 RVA: 0x001FD1C5 File Offset: 0x001FB3C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002BD9 RID: 11225
		// (get) Token: 0x0600D881 RID: 55425 RVA: 0x001FD1C8 File Offset: 0x001FB3C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapTravelLevelUpRequest.Descriptor;
			}
		}

		// Token: 0x0600D882 RID: 55426 RVA: 0x001FD1CF File Offset: 0x001FB3CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTravelLevelUpRequest()
		{
		}

		// Token: 0x0600D883 RID: 55427 RVA: 0x001FD1D7 File Offset: 0x001FB3D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTravelLevelUpRequest(MapTravelLevelUpRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D884 RID: 55428 RVA: 0x001FD1F0 File Offset: 0x001FB3F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTravelLevelUpRequest Clone()
		{
			return new MapTravelLevelUpRequest(this);
		}

		// Token: 0x0600D885 RID: 55429 RVA: 0x001FD1F8 File Offset: 0x001FB3F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapTravelLevelUpRequest);
		}

		// Token: 0x0600D886 RID: 55430 RVA: 0x001FD206 File Offset: 0x001FB406
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapTravelLevelUpRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600D887 RID: 55431 RVA: 0x001FD224 File Offset: 0x001FB424
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

		// Token: 0x0600D888 RID: 55432 RVA: 0x001FD24A File Offset: 0x001FB44A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D889 RID: 55433 RVA: 0x001FD257 File Offset: 0x001FB457
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D88A RID: 55434 RVA: 0x001FD260 File Offset: 0x001FB460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D88B RID: 55435 RVA: 0x001FD278 File Offset: 0x001FB478
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

		// Token: 0x0600D88C RID: 55436 RVA: 0x001FD29E File Offset: 0x001FB49E
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

		// Token: 0x0600D88D RID: 55437 RVA: 0x001FD2BB File Offset: 0x001FB4BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D88E RID: 55438 RVA: 0x001FD2C4 File Offset: 0x001FB4C4
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

		// Token: 0x04005A34 RID: 23092
		private UnknownFieldSet _unknownFields;
	}
}
