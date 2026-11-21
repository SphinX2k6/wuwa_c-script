using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200114F RID: 4431
	[NetMessage(EMessageId.RoverRogueQuitRequest)]
	public sealed class RoverRogueQuitRequest : IMessage<RoverRogueQuitRequest>, IMessage, IEquatable<RoverRogueQuitRequest>, IDeepCloneable<RoverRogueQuitRequest>, IBufferMessage
	{
		// Token: 0x06017ACD RID: 96973 RVA: 0x0037219F File Offset: 0x0037039F
		[NullableContext(1)]
		public static RoverRogueQuitRequest Create()
		{
			return new RoverRogueQuitRequest();
		}

		// Token: 0x17004FA5 RID: 20389
		// (get) Token: 0x06017ACE RID: 96974 RVA: 0x003721A6 File Offset: 0x003703A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004FA6 RID: 20390
		// (get) Token: 0x06017ACF RID: 96975 RVA: 0x003721A9 File Offset: 0x003703A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueQuitRequest.Descriptor;
			}
		}

		// Token: 0x06017AD0 RID: 96976 RVA: 0x003721B0 File Offset: 0x003703B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueQuitRequest()
		{
		}

		// Token: 0x06017AD1 RID: 96977 RVA: 0x003721B8 File Offset: 0x003703B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueQuitRequest(RoverRogueQuitRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017AD2 RID: 96978 RVA: 0x003721DD File Offset: 0x003703DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueQuitRequest Clone()
		{
			return new RoverRogueQuitRequest(this);
		}

		// Token: 0x17004FA7 RID: 20391
		// (get) Token: 0x06017AD3 RID: 96979 RVA: 0x003721E5 File Offset: 0x003703E5
		// (set) Token: 0x06017AD4 RID: 96980 RVA: 0x003721ED File Offset: 0x003703ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x06017AD5 RID: 96981 RVA: 0x003721F6 File Offset: 0x003703F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueQuitRequest);
		}

		// Token: 0x06017AD6 RID: 96982 RVA: 0x00372204 File Offset: 0x00370404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueQuitRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017AD7 RID: 96983 RVA: 0x00372234 File Offset: 0x00370434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017AD8 RID: 96984 RVA: 0x00372273 File Offset: 0x00370473
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017AD9 RID: 96985 RVA: 0x00372280 File Offset: 0x00370480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017ADA RID: 96986 RVA: 0x00372289 File Offset: 0x00370489
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017ADB RID: 96987 RVA: 0x003722BC File Offset: 0x003704BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017ADC RID: 96988 RVA: 0x003722FA File Offset: 0x003704FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueQuitRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017ADD RID: 96989 RVA: 0x0037232B File Offset: 0x0037052B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017ADE RID: 96990 RVA: 0x00372334 File Offset: 0x00370534
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008D47 RID: 36167
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008D48 RID: 36168
		public const int ActivityIdFieldNumber = 9;

		// Token: 0x04008D49 RID: 36169
		private int activityId_;
	}
}
