using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200149B RID: 5275
	[NetMessage(EMessageId.UpdateInstanceTimerNotify)]
	public sealed class UpdateInstanceTimerNotify : IMessage<UpdateInstanceTimerNotify>, IMessage, IEquatable<UpdateInstanceTimerNotify>, IDeepCloneable<UpdateInstanceTimerNotify>, IBufferMessage
	{
		// Token: 0x0601BE6F RID: 114287 RVA: 0x004088BB File Offset: 0x00406ABB
		[NullableContext(1)]
		public static UpdateInstanceTimerNotify Create()
		{
			return new UpdateInstanceTimerNotify();
		}

		// Token: 0x17005E09 RID: 24073
		// (get) Token: 0x0601BE70 RID: 114288 RVA: 0x004088C2 File Offset: 0x00406AC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005E0A RID: 24074
		// (get) Token: 0x0601BE71 RID: 114289 RVA: 0x004088C5 File Offset: 0x00406AC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateInstanceTimerNotify.Descriptor;
			}
		}

		// Token: 0x0601BE72 RID: 114290 RVA: 0x004088CC File Offset: 0x00406ACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateInstanceTimerNotify()
		{
		}

		// Token: 0x0601BE73 RID: 114291 RVA: 0x004088DF File Offset: 0x00406ADF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateInstanceTimerNotify(UpdateInstanceTimerNotify other) : this()
		{
			this.instanceTimers_ = other.instanceTimers_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BE74 RID: 114292 RVA: 0x00408909 File Offset: 0x00406B09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateInstanceTimerNotify Clone()
		{
			return new UpdateInstanceTimerNotify(this);
		}

		// Token: 0x17005E0B RID: 24075
		// (get) Token: 0x0601BE75 RID: 114293 RVA: 0x00408911 File Offset: 0x00406B11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, InstanceTimer> InstanceTimers
		{
			get
			{
				return this.instanceTimers_;
			}
		}

		// Token: 0x0601BE76 RID: 114294 RVA: 0x00408919 File Offset: 0x00406B19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateInstanceTimerNotify);
		}

		// Token: 0x0601BE77 RID: 114295 RVA: 0x00408927 File Offset: 0x00406B27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateInstanceTimerNotify other)
		{
			return other != null && (other == this || (this.InstanceTimers.Equals(other.InstanceTimers) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BE78 RID: 114296 RVA: 0x0040895C File Offset: 0x00406B5C
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

		// Token: 0x0601BE79 RID: 114297 RVA: 0x00408990 File Offset: 0x00406B90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BE7A RID: 114298 RVA: 0x0040899D File Offset: 0x00406B9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BE7B RID: 114299 RVA: 0x004089A6 File Offset: 0x00406BA6
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

		// Token: 0x0601BE7C RID: 114300 RVA: 0x004089D0 File Offset: 0x00406BD0
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

		// Token: 0x0601BE7D RID: 114301 RVA: 0x00408A09 File Offset: 0x00406C09
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

		// Token: 0x0601BE7E RID: 114302 RVA: 0x00408A37 File Offset: 0x00406C37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BE7F RID: 114303 RVA: 0x00408A40 File Offset: 0x00406C40
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
				if (num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.instanceTimers_.AddEntriesFrom(ref input, UpdateInstanceTimerNotify._map_instanceTimers_codec);
				}
			}
		}

		// Token: 0x0400A05F RID: 41055
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A060 RID: 41056
		public const int InstanceTimersFieldNumber = 13;

		// Token: 0x0400A061 RID: 41057
		private static readonly MapField<int, InstanceTimer>.Codec _map_instanceTimers_codec = new MapField<int, InstanceTimer>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<InstanceTimer>(18U, InstanceTimer.Parser), 106U);

		// Token: 0x0400A062 RID: 41058
		private readonly MapField<int, InstanceTimer> instanceTimers_ = new MapField<int, InstanceTimer>();
	}
}
