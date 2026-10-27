using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013E7 RID: 5095
	[NetMessage(EMessageId.TrackMoonRoleDataRequest)]
	public sealed class TrackMoonRoleDataRequest : IMessage<TrackMoonRoleDataRequest>, IMessage, IEquatable<TrackMoonRoleDataRequest>, IDeepCloneable<TrackMoonRoleDataRequest>, IBufferMessage
	{
		// Token: 0x0601B00F RID: 110607 RVA: 0x003E932D File Offset: 0x003E752D
		[NullableContext(1)]
		public static TrackMoonRoleDataRequest Create()
		{
			return new TrackMoonRoleDataRequest();
		}

		// Token: 0x17005B02 RID: 23298
		// (get) Token: 0x0601B010 RID: 110608 RVA: 0x003E9334 File Offset: 0x003E7534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005B03 RID: 23299
		// (get) Token: 0x0601B011 RID: 110609 RVA: 0x003E9337 File Offset: 0x003E7537
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrackMoonRoleDataRequest.Descriptor;
			}
		}

		// Token: 0x0601B012 RID: 110610 RVA: 0x003E933E File Offset: 0x003E753E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonRoleDataRequest()
		{
		}

		// Token: 0x0601B013 RID: 110611 RVA: 0x003E9346 File Offset: 0x003E7546
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonRoleDataRequest(TrackMoonRoleDataRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B014 RID: 110612 RVA: 0x003E935F File Offset: 0x003E755F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonRoleDataRequest Clone()
		{
			return new TrackMoonRoleDataRequest(this);
		}

		// Token: 0x0601B015 RID: 110613 RVA: 0x003E9367 File Offset: 0x003E7567
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrackMoonRoleDataRequest);
		}

		// Token: 0x0601B016 RID: 110614 RVA: 0x003E9375 File Offset: 0x003E7575
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrackMoonRoleDataRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601B017 RID: 110615 RVA: 0x003E9394 File Offset: 0x003E7594
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

		// Token: 0x0601B018 RID: 110616 RVA: 0x003E93BA File Offset: 0x003E75BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B019 RID: 110617 RVA: 0x003E93C7 File Offset: 0x003E75C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B01A RID: 110618 RVA: 0x003E93D0 File Offset: 0x003E75D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B01B RID: 110619 RVA: 0x003E93E8 File Offset: 0x003E75E8
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

		// Token: 0x0601B01C RID: 110620 RVA: 0x003E940E File Offset: 0x003E760E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrackMoonRoleDataRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B01D RID: 110621 RVA: 0x003E942B File Offset: 0x003E762B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B01E RID: 110622 RVA: 0x003E9434 File Offset: 0x003E7634
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

		// Token: 0x04009C59 RID: 40025
		private UnknownFieldSet _unknownFields;
	}
}
