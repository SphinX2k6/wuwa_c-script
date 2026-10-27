using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000988 RID: 2440
	[NetMessage(EMessageId.MapMarkInfoRequest)]
	public sealed class MapMarkInfoRequest : IMessage<MapMarkInfoRequest>, IMessage, IEquatable<MapMarkInfoRequest>, IDeepCloneable<MapMarkInfoRequest>, IBufferMessage
	{
		// Token: 0x0600D687 RID: 54919 RVA: 0x001F8DA9 File Offset: 0x001F6FA9
		[NullableContext(1)]
		public static MapMarkInfoRequest Create()
		{
			return new MapMarkInfoRequest();
		}

		// Token: 0x17002B70 RID: 11120
		// (get) Token: 0x0600D688 RID: 54920 RVA: 0x001F8DB0 File Offset: 0x001F6FB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B71 RID: 11121
		// (get) Token: 0x0600D689 RID: 54921 RVA: 0x001F8DB3 File Offset: 0x001F6FB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapMarkInfoRequest.Descriptor;
			}
		}

		// Token: 0x0600D68A RID: 54922 RVA: 0x001F8DBA File Offset: 0x001F6FBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapMarkInfoRequest()
		{
		}

		// Token: 0x0600D68B RID: 54923 RVA: 0x001F8DC2 File Offset: 0x001F6FC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapMarkInfoRequest(MapMarkInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D68C RID: 54924 RVA: 0x001F8DDB File Offset: 0x001F6FDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapMarkInfoRequest Clone()
		{
			return new MapMarkInfoRequest(this);
		}

		// Token: 0x0600D68D RID: 54925 RVA: 0x001F8DE3 File Offset: 0x001F6FE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapMarkInfoRequest);
		}

		// Token: 0x0600D68E RID: 54926 RVA: 0x001F8DF1 File Offset: 0x001F6FF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapMarkInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600D68F RID: 54927 RVA: 0x001F8E10 File Offset: 0x001F7010
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

		// Token: 0x0600D690 RID: 54928 RVA: 0x001F8E36 File Offset: 0x001F7036
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D691 RID: 54929 RVA: 0x001F8E43 File Offset: 0x001F7043
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D692 RID: 54930 RVA: 0x001F8E4C File Offset: 0x001F704C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D693 RID: 54931 RVA: 0x001F8E64 File Offset: 0x001F7064
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

		// Token: 0x0600D694 RID: 54932 RVA: 0x001F8E8A File Offset: 0x001F708A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MapMarkInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D695 RID: 54933 RVA: 0x001F8EA7 File Offset: 0x001F70A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D696 RID: 54934 RVA: 0x001F8EB0 File Offset: 0x001F70B0
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

		// Token: 0x040059AF RID: 22959
		private UnknownFieldSet _unknownFields;
	}
}
