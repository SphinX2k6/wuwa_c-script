using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200145D RID: 5213
	[NetMessage(EMessageId.TrackMoonSettleRequest)]
	public sealed class TrackMoonSettleRequest : IMessage<TrackMoonSettleRequest>, IMessage, IEquatable<TrackMoonSettleRequest>, IDeepCloneable<TrackMoonSettleRequest>, IBufferMessage
	{
		// Token: 0x0601BACE RID: 113358 RVA: 0x00404AF5 File Offset: 0x00402CF5
		[NullableContext(1)]
		public static TrackMoonSettleRequest Create()
		{
			return new TrackMoonSettleRequest();
		}

		// Token: 0x17005D9F RID: 23967
		// (get) Token: 0x0601BACF RID: 113359 RVA: 0x00404AFC File Offset: 0x00402CFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005DA0 RID: 23968
		// (get) Token: 0x0601BAD0 RID: 113360 RVA: 0x00404AFF File Offset: 0x00402CFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrackMoonSettleRequest.Descriptor;
			}
		}

		// Token: 0x0601BAD1 RID: 113361 RVA: 0x00404B06 File Offset: 0x00402D06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonSettleRequest()
		{
		}

		// Token: 0x0601BAD2 RID: 113362 RVA: 0x00404B0E File Offset: 0x00402D0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonSettleRequest(TrackMoonSettleRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BAD3 RID: 113363 RVA: 0x00404B27 File Offset: 0x00402D27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonSettleRequest Clone()
		{
			return new TrackMoonSettleRequest(this);
		}

		// Token: 0x0601BAD4 RID: 113364 RVA: 0x00404B2F File Offset: 0x00402D2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrackMoonSettleRequest);
		}

		// Token: 0x0601BAD5 RID: 113365 RVA: 0x00404B3D File Offset: 0x00402D3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrackMoonSettleRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601BAD6 RID: 113366 RVA: 0x00404B5C File Offset: 0x00402D5C
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

		// Token: 0x0601BAD7 RID: 113367 RVA: 0x00404B82 File Offset: 0x00402D82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BAD8 RID: 113368 RVA: 0x00404B8F File Offset: 0x00402D8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BAD9 RID: 113369 RVA: 0x00404B98 File Offset: 0x00402D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BADA RID: 113370 RVA: 0x00404BB0 File Offset: 0x00402DB0
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

		// Token: 0x0601BADB RID: 113371 RVA: 0x00404BD6 File Offset: 0x00402DD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrackMoonSettleRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BADC RID: 113372 RVA: 0x00404BF3 File Offset: 0x00402DF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BADD RID: 113373 RVA: 0x00404BFC File Offset: 0x00402DFC
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

		// Token: 0x0400A0A9 RID: 41129
		private UnknownFieldSet _unknownFields;
	}
}
