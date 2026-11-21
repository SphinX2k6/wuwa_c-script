using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200150F RID: 5391
	[NetMessage(EMessageId.UpdateInstanceTimerNotify)]
	public sealed class UpdateInstanceTimerNotify : IMessage<UpdateInstanceTimerNotify>, IMessage, IEquatable<UpdateInstanceTimerNotify>, IDeepCloneable<UpdateInstanceTimerNotify>, IBufferMessage
	{
		// Token: 0x0601C90C RID: 117004 RVA: 0x00423D5F File Offset: 0x00421F5F
		[NullableContext(1)]
		public static UpdateInstanceTimerNotify Create()
		{
			return new UpdateInstanceTimerNotify();
		}

		// Token: 0x170060A1 RID: 24737
		// (get) Token: 0x0601C90D RID: 117005 RVA: 0x00423D66 File Offset: 0x00421F66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170060A2 RID: 24738
		// (get) Token: 0x0601C90E RID: 117006 RVA: 0x00423D69 File Offset: 0x00421F69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateInstanceTimerNotify.Descriptor;
			}
		}

		// Token: 0x0601C90F RID: 117007 RVA: 0x00423D70 File Offset: 0x00421F70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateInstanceTimerNotify()
		{
		}

		// Token: 0x0601C910 RID: 117008 RVA: 0x00423D83 File Offset: 0x00421F83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateInstanceTimerNotify(UpdateInstanceTimerNotify other) : this()
		{
			this.instanceTimers_ = other.instanceTimers_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C911 RID: 117009 RVA: 0x00423DAD File Offset: 0x00421FAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateInstanceTimerNotify Clone()
		{
			return new UpdateInstanceTimerNotify(this);
		}

		// Token: 0x170060A3 RID: 24739
		// (get) Token: 0x0601C912 RID: 117010 RVA: 0x00423DB5 File Offset: 0x00421FB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, InstanceTimer> InstanceTimers
		{
			get
			{
				return this.instanceTimers_;
			}
		}

		// Token: 0x0601C913 RID: 117011 RVA: 0x00423DBD File Offset: 0x00421FBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateInstanceTimerNotify);
		}

		// Token: 0x0601C914 RID: 117012 RVA: 0x00423DCB File Offset: 0x00421FCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateInstanceTimerNotify other)
		{
			return other != null && (other == this || (this.InstanceTimers.Equals(other.InstanceTimers) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C915 RID: 117013 RVA: 0x00423E00 File Offset: 0x00422000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.InstanceTimers.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C916 RID: 117014 RVA: 0x00423E34 File Offset: 0x00422034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C917 RID: 117015 RVA: 0x00423E41 File Offset: 0x00422041
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C918 RID: 117016 RVA: 0x00423E4A File Offset: 0x0042204A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.instanceTimers_.WriteTo(ref output, UpdateInstanceTimerNotify._map_instanceTimers_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C919 RID: 117017 RVA: 0x00423E74 File Offset: 0x00422074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.instanceTimers_.CalculateSize(UpdateInstanceTimerNotify._map_instanceTimers_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C91A RID: 117018 RVA: 0x00423EAD File Offset: 0x004220AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdateInstanceTimerNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.instanceTimers_.MergeFrom(other.instanceTimers_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C91B RID: 117019 RVA: 0x00423EDB File Offset: 0x004220DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C91C RID: 117020 RVA: 0x00423EE4 File Offset: 0x004220E4
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
				if (num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.instanceTimers_.AddEntriesFrom(ref input, UpdateInstanceTimerNotify._map_instanceTimers_codec);
				}
			}
		}

		// Token: 0x0400A4AA RID: 42154
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A4AB RID: 42155
		public const int InstanceTimersFieldNumber = 15;

		// Token: 0x0400A4AC RID: 42156
		private static readonly MapField<int, InstanceTimer>.Codec _map_instanceTimers_codec = new MapField<int, InstanceTimer>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<InstanceTimer>(18U, InstanceTimer.Parser), 122U);

		// Token: 0x0400A4AD RID: 42157
		private readonly MapField<int, InstanceTimer> instanceTimers_ = new MapField<int, InstanceTimer>();
	}
}
