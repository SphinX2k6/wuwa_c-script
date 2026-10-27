using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200077A RID: 1914
	[NetMessage(EMessageId.HonamiStoryInstLeaveRequest)]
	public sealed class HonamiStoryInstLeaveRequest : IMessage<HonamiStoryInstLeaveRequest>, IMessage, IEquatable<HonamiStoryInstLeaveRequest>, IDeepCloneable<HonamiStoryInstLeaveRequest>, IBufferMessage
	{
		// Token: 0x0600ACFA RID: 44282 RVA: 0x0019FDD9 File Offset: 0x0019DFD9
		[NullableContext(1)]
		public static HonamiStoryInstLeaveRequest Create()
		{
			return new HonamiStoryInstLeaveRequest();
		}

		// Token: 0x170022E1 RID: 8929
		// (get) Token: 0x0600ACFB RID: 44283 RVA: 0x0019FDE0 File Offset: 0x0019DFE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170022E2 RID: 8930
		// (get) Token: 0x0600ACFC RID: 44284 RVA: 0x0019FDE3 File Offset: 0x0019DFE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryInstLeaveRequest.Descriptor;
			}
		}

		// Token: 0x0600ACFD RID: 44285 RVA: 0x0019FDEA File Offset: 0x0019DFEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryInstLeaveRequest()
		{
		}

		// Token: 0x0600ACFE RID: 44286 RVA: 0x0019FDF2 File Offset: 0x0019DFF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryInstLeaveRequest(HonamiStoryInstLeaveRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ACFF RID: 44287 RVA: 0x0019FE0B File Offset: 0x0019E00B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryInstLeaveRequest Clone()
		{
			return new HonamiStoryInstLeaveRequest(this);
		}

		// Token: 0x0600AD00 RID: 44288 RVA: 0x0019FE13 File Offset: 0x0019E013
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryInstLeaveRequest);
		}

		// Token: 0x0600AD01 RID: 44289 RVA: 0x0019FE21 File Offset: 0x0019E021
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryInstLeaveRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600AD02 RID: 44290 RVA: 0x0019FE40 File Offset: 0x0019E040
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

		// Token: 0x0600AD03 RID: 44291 RVA: 0x0019FE66 File Offset: 0x0019E066
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AD04 RID: 44292 RVA: 0x0019FE73 File Offset: 0x0019E073
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AD05 RID: 44293 RVA: 0x0019FE7C File Offset: 0x0019E07C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AD06 RID: 44294 RVA: 0x0019FE94 File Offset: 0x0019E094
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

		// Token: 0x0600AD07 RID: 44295 RVA: 0x0019FEBA File Offset: 0x0019E0BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryInstLeaveRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AD08 RID: 44296 RVA: 0x0019FED7 File Offset: 0x0019E0D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AD09 RID: 44297 RVA: 0x0019FEE0 File Offset: 0x0019E0E0
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

		// Token: 0x04004E4B RID: 20043
		private UnknownFieldSet _unknownFields;
	}
}
