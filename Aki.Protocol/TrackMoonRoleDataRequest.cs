using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200145A RID: 5210
	[NetMessage(EMessageId.TrackMoonRoleDataRequest)]
	public sealed class TrackMoonRoleDataRequest : IMessage<TrackMoonRoleDataRequest>, IMessage, IEquatable<TrackMoonRoleDataRequest>, IDeepCloneable<TrackMoonRoleDataRequest>, IBufferMessage
	{
		// Token: 0x0601BA9A RID: 113306 RVA: 0x004045F9 File Offset: 0x004027F9
		[NullableContext(1)]
		public static TrackMoonRoleDataRequest Create()
		{
			return new TrackMoonRoleDataRequest();
		}

		// Token: 0x17005D97 RID: 23959
		// (get) Token: 0x0601BA9B RID: 113307 RVA: 0x00404600 File Offset: 0x00402800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D98 RID: 23960
		// (get) Token: 0x0601BA9C RID: 113308 RVA: 0x00404603 File Offset: 0x00402803
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrackMoonRoleDataRequest.Descriptor;
			}
		}

		// Token: 0x0601BA9D RID: 113309 RVA: 0x0040460A File Offset: 0x0040280A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonRoleDataRequest()
		{
		}

		// Token: 0x0601BA9E RID: 113310 RVA: 0x00404612 File Offset: 0x00402812
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonRoleDataRequest(TrackMoonRoleDataRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BA9F RID: 113311 RVA: 0x0040462B File Offset: 0x0040282B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonRoleDataRequest Clone()
		{
			return new TrackMoonRoleDataRequest(this);
		}

		// Token: 0x0601BAA0 RID: 113312 RVA: 0x00404633 File Offset: 0x00402833
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrackMoonRoleDataRequest);
		}

		// Token: 0x0601BAA1 RID: 113313 RVA: 0x00404641 File Offset: 0x00402841
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrackMoonRoleDataRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601BAA2 RID: 113314 RVA: 0x00404660 File Offset: 0x00402860
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

		// Token: 0x0601BAA3 RID: 113315 RVA: 0x00404686 File Offset: 0x00402886
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BAA4 RID: 113316 RVA: 0x00404693 File Offset: 0x00402893
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BAA5 RID: 113317 RVA: 0x0040469C File Offset: 0x0040289C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BAA6 RID: 113318 RVA: 0x004046B4 File Offset: 0x004028B4
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

		// Token: 0x0601BAA7 RID: 113319 RVA: 0x004046DA File Offset: 0x004028DA
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

		// Token: 0x0601BAA8 RID: 113320 RVA: 0x004046F7 File Offset: 0x004028F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BAA9 RID: 113321 RVA: 0x00404700 File Offset: 0x00402900
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

		// Token: 0x0400A0A0 RID: 41120
		private UnknownFieldSet _unknownFields;
	}
}
